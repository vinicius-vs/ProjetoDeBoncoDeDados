
namespace Condominios_Sol_Nascente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtCon1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtCon1
            // 
            this.BtCon1.Location = new System.Drawing.Point(294, 37);
            this.BtCon1.Name = "BtCon1";
            this.BtCon1.Size = new System.Drawing.Size(150, 49);
            this.BtCon1.TabIndex = 0;
            this.BtCon1.Text = "Cadastrar Condominio";
            this.BtCon1.UseVisualStyleBackColor = true;
            this.BtCon1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtCon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Sol Nascente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtCon1;
    }
}

