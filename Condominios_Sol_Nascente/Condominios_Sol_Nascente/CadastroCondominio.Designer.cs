
namespace Condominios_Sol_Nascente
{
    partial class CadastroCondominio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCondominio));
            this.TbNomeCon = new System.Windows.Forms.TextBox();
            this.LbNoCo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbEndCon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbCnpjCon = new System.Windows.Forms.TextBox();
            this.BtSalvarCon = new System.Windows.Forms.Button();
            this.BtCancelarCon = new System.Windows.Forms.Button();
            this.dgCon = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCon)).BeginInit();
            this.SuspendLayout();
            // 
            // TbNomeCon
            // 
            this.TbNomeCon.Location = new System.Drawing.Point(71, 114);
            this.TbNomeCon.Name = "TbNomeCon";
            this.TbNomeCon.Size = new System.Drawing.Size(205, 20);
            this.TbNomeCon.TabIndex = 0;
            // 
            // LbNoCo
            // 
            this.LbNoCo.AutoSize = true;
            this.LbNoCo.Location = new System.Drawing.Point(30, 117);
            this.LbNoCo.Name = "LbNoCo";
            this.LbNoCo.Size = new System.Drawing.Size(38, 13);
            this.LbNoCo.TabIndex = 1;
            this.LbNoCo.Text = "Nome:";
            this.LbNoCo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Endereço:";
            // 
            // TbEndCon
            // 
            this.TbEndCon.Location = new System.Drawing.Point(71, 152);
            this.TbEndCon.Name = "TbEndCon";
            this.TbEndCon.Size = new System.Drawing.Size(205, 20);
            this.TbEndCon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cnpj:";
            // 
            // TbCnpjCon
            // 
            this.TbCnpjCon.Location = new System.Drawing.Point(71, 192);
            this.TbCnpjCon.Name = "TbCnpjCon";
            this.TbCnpjCon.Size = new System.Drawing.Size(205, 20);
            this.TbCnpjCon.TabIndex = 4;
            // 
            // BtSalvarCon
            // 
            this.BtSalvarCon.Location = new System.Drawing.Point(71, 237);
            this.BtSalvarCon.Name = "BtSalvarCon";
            this.BtSalvarCon.Size = new System.Drawing.Size(64, 23);
            this.BtSalvarCon.TabIndex = 6;
            this.BtSalvarCon.Text = "Salvar";
            this.BtSalvarCon.UseVisualStyleBackColor = true;
            this.BtSalvarCon.Click += new System.EventHandler(this.BtSalvarCon_Click);
            // 
            // BtCancelarCon
            // 
            this.BtCancelarCon.Location = new System.Drawing.Point(212, 237);
            this.BtCancelarCon.Name = "BtCancelarCon";
            this.BtCancelarCon.Size = new System.Drawing.Size(64, 23);
            this.BtCancelarCon.TabIndex = 7;
            this.BtCancelarCon.Text = "Cancelar";
            this.BtCancelarCon.UseVisualStyleBackColor = true;
            this.BtCancelarCon.Click += new System.EventHandler(this.BtCancelarCon_Click);
            // 
            // dgCon
            // 
            this.dgCon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgCon.AllowUserToAddRows = false;
            this.dgCon.AllowUserToDeleteRows = false;
            this.dgCon.AllowUserToResizeColumns = false;
            this.dgCon.AllowUserToResizeRows = false;
            this.dgCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Endereco,
            this.Cnpj,
            this.Deletar,
            this.Alterar});
            this.dgCon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgCon.Location = new System.Drawing.Point(320, 12);
            this.dgCon.Name = "dgCon";
            this.dgCon.ShowCellErrors = false;
            this.dgCon.ShowCellToolTips = false;
            this.dgCon.ShowEditingIcon = false;
            this.dgCon.ShowRowErrors = false;
            this.dgCon.Size = new System.Drawing.Size(468, 426);
            this.dgCon.TabIndex = 8;
            this.dgCon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCon_CellContentClick);
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
            // Cnpj
            // 
            this.Cnpj.HeaderText = "Cnpj";
            this.Cnpj.Name = "Cnpj";
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "";
            this.Deletar.Name = "Deletar";
            this.Deletar.Width = 50;
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "";
            this.Alterar.Name = "Alterar";
            this.Alterar.Width = 50;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(71, 78);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(205, 20);
            this.tbId.TabIndex = 9;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(40, 81);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 13);
            this.lbId.TabIndex = 10;
            this.lbId.Text = "ID:";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // CadastroCondominio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.dgCon);
            this.Controls.Add(this.BtCancelarCon);
            this.Controls.Add(this.BtSalvarCon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbCnpjCon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbEndCon);
            this.Controls.Add(this.LbNoCo);
            this.Controls.Add(this.TbNomeCon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroCondominio";
            this.Text = "Cadastro Condominio";
            ((System.ComponentModel.ISupportInitialize)(this.dgCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNomeCon;
        private System.Windows.Forms.Label LbNoCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbEndCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbCnpjCon;
        private System.Windows.Forms.Button BtSalvarCon;
        private System.Windows.Forms.Button BtCancelarCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alterar;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.DataGridView dgCon;
    }
}