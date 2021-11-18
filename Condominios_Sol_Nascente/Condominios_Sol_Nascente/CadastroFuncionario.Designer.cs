
namespace Condominios_Sol_Nascente
{
    partial class CadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.dgFun = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtCancelarFun = new System.Windows.Forms.Button();
            this.BtSalvarFun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbCpfFun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbEndFun = new System.Windows.Forms.TextBox();
            this.LbNoCo = new System.Windows.Forms.Label();
            this.TbNomeFun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTurnoFun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFuncaoFun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSalFun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbConFun = new System.Windows.Forms.TextBox();
            this.lbAvisoFun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFun)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(40, 37);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 13);
            this.lbId.TabIndex = 21;
            this.lbId.Text = "ID:";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(71, 34);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(205, 20);
            this.tbId.TabIndex = 20;
            // 
            // dgFun
            // 
            this.dgFun.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgFun.AllowUserToAddRows = false;
            this.dgFun.AllowUserToDeleteRows = false;
            this.dgFun.AllowUserToResizeColumns = false;
            this.dgFun.AllowUserToResizeRows = false;
            this.dgFun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar,
            this.Editar,
            this.Id,
            this.Nome,
            this.Endereco,
            this.Cpf,
            this.Turno,
            this.Funcao,
            this.Salario,
            this.Condominio});
            this.dgFun.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgFun.Location = new System.Drawing.Point(320, 12);
            this.dgFun.Name = "dgFun";
            this.dgFun.ShowCellErrors = false;
            this.dgFun.ShowCellToolTips = false;
            this.dgFun.ShowEditingIcon = false;
            this.dgFun.ShowRowErrors = false;
            this.dgFun.Size = new System.Drawing.Size(468, 426);
            this.dgFun.TabIndex = 19;
            this.dgFun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFun_CellContentClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "";
            this.Deletar.Name = "Deletar";
            this.Deletar.Width = 50;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Width = 50;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 25;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            // 
            // Funcao
            // 
            this.Funcao.HeaderText = "Função ";
            this.Funcao.Name = "Funcao";
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salário";
            this.Salario.Name = "Salario";
            // 
            // Condominio
            // 
            this.Condominio.HeaderText = "Condomínio";
            this.Condominio.Name = "Condominio";
            // 
            // BtCancelarFun
            // 
            this.BtCancelarFun.Location = new System.Drawing.Point(212, 367);
            this.BtCancelarFun.Name = "BtCancelarFun";
            this.BtCancelarFun.Size = new System.Drawing.Size(64, 23);
            this.BtCancelarFun.TabIndex = 18;
            this.BtCancelarFun.Text = "Cancelar";
            this.BtCancelarFun.UseVisualStyleBackColor = true;
            this.BtCancelarFun.Click += new System.EventHandler(this.BtCancelarFun_Click);
            // 
            // BtSalvarFun
            // 
            this.BtSalvarFun.Location = new System.Drawing.Point(71, 367);
            this.BtSalvarFun.Name = "BtSalvarFun";
            this.BtSalvarFun.Size = new System.Drawing.Size(64, 23);
            this.BtSalvarFun.TabIndex = 17;
            this.BtSalvarFun.Text = "Salvar";
            this.BtSalvarFun.UseVisualStyleBackColor = true;
            this.BtSalvarFun.Click += new System.EventHandler(this.BtSalvarFun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cpf:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TbCpfFun
            // 
            this.TbCpfFun.Location = new System.Drawing.Point(71, 148);
            this.TbCpfFun.Name = "TbCpfFun";
            this.TbCpfFun.Size = new System.Drawing.Size(205, 20);
            this.TbCpfFun.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Endereço:";
            // 
            // TbEndFun
            // 
            this.TbEndFun.Location = new System.Drawing.Point(71, 108);
            this.TbEndFun.Name = "TbEndFun";
            this.TbEndFun.Size = new System.Drawing.Size(205, 20);
            this.TbEndFun.TabIndex = 13;
            // 
            // LbNoCo
            // 
            this.LbNoCo.AutoSize = true;
            this.LbNoCo.Location = new System.Drawing.Point(30, 73);
            this.LbNoCo.Name = "LbNoCo";
            this.LbNoCo.Size = new System.Drawing.Size(38, 13);
            this.LbNoCo.TabIndex = 12;
            this.LbNoCo.Text = "Nome:";
            // 
            // TbNomeFun
            // 
            this.TbNomeFun.Location = new System.Drawing.Point(71, 70);
            this.TbNomeFun.Name = "TbNomeFun";
            this.TbNomeFun.Size = new System.Drawing.Size(205, 20);
            this.TbNomeFun.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Turno:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbTurnoFun
            // 
            this.tbTurnoFun.Location = new System.Drawing.Point(71, 188);
            this.tbTurnoFun.Name = "tbTurnoFun";
            this.tbTurnoFun.Size = new System.Drawing.Size(205, 20);
            this.tbTurnoFun.TabIndex = 22;
            this.tbTurnoFun.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Função:";
            // 
            // tbFuncaoFun
            // 
            this.tbFuncaoFun.Location = new System.Drawing.Point(71, 229);
            this.tbFuncaoFun.Name = "tbFuncaoFun";
            this.tbFuncaoFun.Size = new System.Drawing.Size(205, 20);
            this.tbFuncaoFun.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Salario:";
            // 
            // tbSalFun
            // 
            this.tbSalFun.Location = new System.Drawing.Point(71, 270);
            this.tbSalFun.Name = "tbSalFun";
            this.tbSalFun.Size = new System.Drawing.Size(205, 20);
            this.tbSalFun.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Condomínio:";
            // 
            // tbConFun
            // 
            this.tbConFun.Location = new System.Drawing.Point(71, 308);
            this.tbConFun.Name = "tbConFun";
            this.tbConFun.Size = new System.Drawing.Size(205, 20);
            this.tbConFun.TabIndex = 29;
            // 
            // lbAvisoFun
            // 
            this.lbAvisoFun.AutoSize = true;
            this.lbAvisoFun.Location = new System.Drawing.Point(71, 339);
            this.lbAvisoFun.Name = "lbAvisoFun";
            this.lbAvisoFun.Size = new System.Drawing.Size(0, 13);
            this.lbAvisoFun.TabIndex = 30;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAvisoFun);
            this.Controls.Add(this.tbConFun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSalFun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFuncaoFun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTurnoFun);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.dgFun);
            this.Controls.Add(this.BtCancelarFun);
            this.Controls.Add(this.BtSalvarFun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbCpfFun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbEndFun);
            this.Controls.Add(this.LbNoCo);
            this.Controls.Add(this.TbNomeFun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroFuncionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.CadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.DataGridView dgFun;
        private System.Windows.Forms.Button BtCancelarFun;
        private System.Windows.Forms.Button BtSalvarFun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbCpfFun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbEndFun;
        private System.Windows.Forms.Label LbNoCo;
        private System.Windows.Forms.TextBox TbNomeFun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTurnoFun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFuncaoFun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSalFun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbConFun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condominio;
        private System.Windows.Forms.Label lbAvisoFun;
    }
}