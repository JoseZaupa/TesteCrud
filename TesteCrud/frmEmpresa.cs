using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteCrud
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            EmpresaRep empRep = new EmpresaRep();
            if(empRep.ListarTodos().Count() > 0)
            {
                gridEmp.DataSource = null;
                gridEmp.DataSource = empRep.ListarTodos();
                gridEmp.Refresh();
            }
        }

        private void btcCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
            {
                MessageBox.Show("Verifique os campos");
            }
            else
            {
                try
                {
                    EmpresaRep empRep = new EmpresaRep();
                    Empresas empresa = new Empresas()
                    {
                        Id = int.Parse(txtId.Text),
                        Nome = txtNome.Text,
                        Site = txtSite.Text,
                        QtdFunc = int.Parse(txtQtdFunc.Text)
                    };
                    empRep.Salvar(empresa);
                    if(empresa.Id.Equals(0))
                        MessageBox.Show("Registro inserido com sucesso!");
                    else
                        MessageBox.Show("Registro alterado com sucesso!");

                    gridEmp.DataSource = null;
                    gridEmp.DataSource = empRep.ListarTodos();
                    gridEmp.Refresh();
                    LimpaCampos();
                    btnSalvar.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.ToString());
                }
            }
        }

        public bool ValidaCampos()
        {
            if (txtNome.Text.Equals(""))
                return false;

            if (txtSite.Text.Equals(""))
                return false;

            if (txtQtdFunc.Text.Equals(""))
               return false;

            return true;
        }
        public void LimpaCampos()
        {
            txtId.Text = "0";
            txtNome.Text = "";
            txtSite.Text = "";
            txtQtdFunc.Text = "";
            
        }

        private void gridEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gridEmp_Click(object sender, EventArgs e)
        {
            if (gridEmp.Rows.Count > 0)
            {
                txtId.Text = gridEmp.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = gridEmp.CurrentRow.Cells[1].Value.ToString();
                txtSite.Text = gridEmp.CurrentRow.Cells[2].Value.ToString();
                txtQtdFunc.Text = gridEmp.CurrentRow.Cells[3].Value.ToString();
                if (!txtId.Text.Equals(""))
                    btnSalvar.Enabled = true;

            }
        }
         
        private void gridEmp_RowEnter(object sender, DataGridViewCellEventArgs e)
        {   
           
           //  
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(!txtId.Text.Equals("") && !txtId.Text.Equals("0"))
            {
                try
                {
                    EmpresaRep empRep = new EmpresaRep();
                    Empresas empresa = new Empresas();
                    empresa.Id = int.Parse(txtId.Text);
                    var resposta = MessageBox.Show("Desesa excluir o registro de ID: " + empresa.Id.ToString(), "Excluir", MessageBoxButtons.YesNo);
                    if (resposta == DialogResult.Yes)
                    {
                        empRep.Excluir(empresa);
                        MessageBox.Show("Registro excluído com sucesso!");
                        gridEmp.DataSource = null;
                        gridEmp.DataSource = empRep.ListarTodos();
                        gridEmp.Refresh();
                        LimpaCampos();
                        btnSalvar.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.ToString());
                }
            }

        }

        

        private void txtId_TextChanged(object sender, EventArgs e)
        {

           
        }

        
    }
}
