namespace TesteCrud
{
    partial class frmEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQtdFunc = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtQtdFunc = new System.Windows.Forms.TextBox();
            this.btcCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gridEmp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(64, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(45, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblQtdFunc
            // 
            this.lblQtdFunc.AutoSize = true;
            this.lblQtdFunc.Location = new System.Drawing.Point(14, 109);
            this.lblQtdFunc.Name = "lblQtdFunc";
            this.lblQtdFunc.Size = new System.Drawing.Size(66, 13);
            this.lblQtdFunc.TabIndex = 2;
            this.lblQtdFunc.Text = "Quant, Func";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(55, 83);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(25, 13);
            this.lblSite.TabIndex = 3;
            this.lblSite.Text = "Site";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(86, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(133, 20);
            this.txtId.TabIndex = 4;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(343, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(86, 80);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(343, 20);
            this.txtSite.TabIndex = 6;
            // 
            // txtQtdFunc
            // 
            this.txtQtdFunc.Location = new System.Drawing.Point(86, 106);
            this.txtQtdFunc.Name = "txtQtdFunc";
            this.txtQtdFunc.Size = new System.Drawing.Size(133, 20);
            this.txtQtdFunc.TabIndex = 7;
            // 
            // btcCancelar
            // 
            this.btcCancelar.Location = new System.Drawing.Point(308, 335);
            this.btcCancelar.Name = "btcCancelar";
            this.btcCancelar.Size = new System.Drawing.Size(75, 23);
            this.btcCancelar.TabIndex = 10;
            this.btcCancelar.Text = "Cancelar";
            this.btcCancelar.UseVisualStyleBackColor = true;
            this.btcCancelar.Click += new System.EventHandler(this.btcCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(227, 335);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(146, 335);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(65, 335);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gridEmp
            // 
            this.gridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmp.Location = new System.Drawing.Point(8, 148);
            this.gridEmp.Name = "gridEmp";
            this.gridEmp.Size = new System.Drawing.Size(446, 163);
            this.gridEmp.TabIndex = 17;
            this.gridEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmp_CellContentClick);
            this.gridEmp.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmp_RowEnter);
            this.gridEmp.Click += new System.EventHandler(this.gridEmp_Click);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 370);
            this.Controls.Add(this.gridEmp);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btcCancelar);
            this.Controls.Add(this.txtQtdFunc);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.lblQtdFunc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQtdFunc;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtQtdFunc;
        private System.Windows.Forms.Button btcCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView gridEmp;
    }
}