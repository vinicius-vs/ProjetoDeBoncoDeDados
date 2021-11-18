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
            CarregarTabela();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void CarregarTabela()
        {
            dgFun.Rows.Clear();


            foreach (Funcionario fun in funcionarioRepository.Read())
            {
                
                dgFun.Rows.Add("Delete", "Edite", fun.id, fun.nome, fun.endereco, fun.cpf, fun.turno, fun.funcao, fun.salario, fun.condominioId);
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
       
            try
            {

                funcionario.nome = TbNomeFun.Text;
                funcionario.condominioId = int.Parse(tbConFun.Text);
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
                CarregarTabela();
            }
            catch (Exception)
            {
                lbAvisoFun.Text = "Condominio não valido";
            }
         }

        private void BtCancelarFun_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }
        private void PrencherDados(Funcionario model)
        {
            TbNomeFun.Text = model.nome;
            tbConFun.Text = Convert.ToString( model.condominioId);
            tbFuncaoFun.Text = model.funcao;
            tbId.Text = Convert.ToString( model.id);
            tbSalFun.Text = Convert.ToString( model.salario);
            tbTurnoFun.Text = model.turno;
            TbCpfFun.Text = model.cpf;
            TbEndFun.Text = model.endereco;
        }

        private void dgFun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Funcionario> funcionarios = funcionarioRepository.Read();

            Funcionario fun = funcionarios[e.RowIndex];


            if (e.ColumnIndex.Equals(0))
            {
                funcionarioRepository.Delete(fun.id);
            }
            else if (e.ColumnIndex.Equals(1))
            {
                PrencherDados(fun);
            }
            CarregarTabela();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            lbAvisoFun.Text = string.Empty;
        }
    }
}
