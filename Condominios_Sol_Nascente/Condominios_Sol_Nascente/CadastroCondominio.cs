using Data.Models;
using Data.Repositorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condominios_Sol_Nascente
{
    public partial class CadastroCondominio : Form
    {
        private CondominioRepository Condominios;
        public CadastroCondominio()
        {
            InitializeComponent();
            Condominios = new CondominioRepository();
            dgCon.AutoGenerateColumns = false;
            dgCon.AllowUserToAddRows = false;
            CarregarCondominios();
        }

        private void LinparCampos()
        {
            TbNomeCon.Text = string.Empty;
            TbCnpjCon.Text = string.Empty;
            TbEndCon.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtSalvarCon_Click(object sender, EventArgs e)
        {
            Condominio con = new Condominio();
            con.nome = TbNomeCon.Text;
            con.cnpj = TbCnpjCon.Text;
            con.endereco = TbEndCon.Text;
            Condominios.Create(con);
            LinparCampos();
            CarregarCondominios();
        }

        private void BtCancelarCon_Click(object sender, EventArgs e)
        {
            LinparCampos();
        }

        private void CarregarCondominios()
        {
            dgCon.Rows.Clear();

            foreach (Condominio con in Condominios.Read())
            {
                dgCon.Rows.Add(con.id, con.nome, con.endereco, con.cnpj, "Deletar", "Editar");
            }
            dgCon.Refresh();
        }

        private void dgCon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Condominio> cons = Condominios.Read();

            Condominio con = cons[e.RowIndex];
         

            if(e.ColumnIndex.Equals(4))
            {
                Condominios.Delete(con.id);
            }

            CarregarCondominios();
        }
    }
}
