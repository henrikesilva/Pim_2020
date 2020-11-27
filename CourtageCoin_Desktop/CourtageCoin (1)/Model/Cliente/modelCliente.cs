using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourtageCoin.Model.Cliente
{
    public class modelCliente
    {
        //construtures
        public modelCliente()
        {
            this.cli_Carteira = 0;
            this.cli_Nome = "";
            this.cli_CPF = "";
            this.cli_RG = "";
            this.cli_CEP = "";
            this.cli_Endereco = "";
            this.cli_Cidade = "";
            this.cli_Estado = "";
            this.cli_Email = "";
            this.cli_Telefone = "";
        }

        public modelCliente(int cod, string nome, string cpf, string rg, 
            string cep, string end, string cid, string est, string email, 
            string tel)
        {
            this.cli_Carteira = cod;
            this.cli_Nome = nome;
            this.cli_CPF = cpf;
            this.cli_RG = rg;
            this.cli_CEP = cep;
            this.cli_Endereco = end;
            this.cli_Cidade = cid;
            this.cli_Estado = est;
            this.cli_Email = email;
            this.cli_Telefone = tel;
        }

        private int cli_Carteira;

        public int cliCarteira
        {
            get { return this.cli_Carteira; }
            set { this.cli_Carteira = value; }

        }
       
        private string cli_Nome;

        public string cliNome
        {
            get { return this.cli_Nome; }
            set { this.cli_Nome = value; }
        }

        private string cli_CPF;

        public string cliCPF
        {
            get { return this.cli_CPF; }
            set { this.cli_CPF = value; }
        }

        private string cli_Endereco;

        public string cliEndereco
        {
            get { return this.cli_Endereco; }
            set { this.cli_Endereco = value; }
        }

        private string cli_Cidade;

        public string cliCidade
        {
            get { return this.cli_Cidade; }
            set { this.cli_Cidade = value; }
        }

        private string cli_Telefone;

        public string cliTelefone
        {
            get { return this.cli_Telefone; }
            set { this.cli_Telefone = value; }
        }

        private string cli_RG;

        public string cliRG
        {
            get { return this.cli_RG; }
            set { this.cli_RG = value; }
        }

        private string cli_Email;

        public string cliEmail
        {
            get { return this.cli_Email; }
            set { this.cli_Email = value; }
        }

        private string cli_CEP;

        public string cliCEP
        {
            get { return this.cli_CEP; }
            set { this.cli_CEP = value; }
        }

        private string cli_Estado;
        public string cliEstado
        {
            get { return this.cli_Estado; }
            set { this.cli_Estado = value; }
        }

    }
}
