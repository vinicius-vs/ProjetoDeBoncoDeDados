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
    public partial class CadastroFuncionario : Form
    {

        private FuncionarioRepository funcionarioRepository;

        public CadastroFuncionario()
        {
            funcionarioRepository = new FuncionarioRepository();
            InitializeComponent();
            dgFun.AllowUserToAddRows = false;
            dgFun.AutoGenerateColumns = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void CarregarTabela()
        {
            dgFun.Rows.Clear();

            foreach(Funcionario fun in funcionarioRepository.Read())
            {
                //dgFun.Rows.Add("Delete", "Edite",fun.id,fun.)
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimparCampo()
        {
            tbId.Text = string.Empty;
            TbNomeFun.Text = string.Empty;
            TbEndFun.Text = string.Empty;
            TbCpfFun.Text = string.Empty;
            tbConFun.Text = string.Empty;
            tbFuncaoFun.Text = string.Empty;
            tbSalFun.Text = string.Empty;
            tbTurnoFun.Text = string.Empty;
            lbAvisoFun.Text = string.Empty;
        }

        private void BtSalvarFun_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            CondominioRepository condominio = new CondominioRepository();
            try
            {
                funcionario.nome = TbNomeFun.Text;
                funcionario.condominio = condominio.Read(int.Parse(tbConFun.Text));
                funcionario.cpf = TbCpfFun.Text;
                funcionario.funcao = tbFuncaoFun.Text;
                funcionario.endereco = TbEndFun.Text;
                funcionario.salario =Convert.ToDecimal(tbSalFun.Text);
                funcionario.turno = tbTurnoFun.Text;
                if (tbId.Text.Equals(""))
                {
                    funcionarioRepository.Create(funcionario);
                    LimparCampo();
                }
                else
                {
                    funcionario.id = int.Parse(tbId.Text);
                    funcionarioRepository.Update(funcionario);
                    LimparCampo();
                }
            }
            catch (Exception test)
            {
                lbAvisoFun.Text = "Condominio não valido" + test ;
            }
         }

        private void BtCancelarFun_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void dgFun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
