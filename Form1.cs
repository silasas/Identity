using Identity.Data.Context;
using Identity.Data.Repositories;
using Identity.Domain.Entities;
using System;
using System.Windows.Forms;

namespace Identity
{
    public partial class Form1 : Form
    {
        Startup startup { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Funcionario ifuncionario = new Funcionario();
            ifuncionario.Codigo = 18192021;
            ifuncionario.Nome = "Silas_1D";

            using (var func = new FuncionarioRepository(new DbContexto()))
            {
                func.Adicionar(ifuncionario);
                func.Commit();
            }
        }
    }
}
