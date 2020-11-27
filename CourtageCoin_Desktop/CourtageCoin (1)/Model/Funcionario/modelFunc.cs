using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourtageCoin.Model.Funcionario
{
    class modelFunc
    {
         //construtures
        public modelFunc()
        {
            this.func_Cod = 0;
            this.func_Nome = "";
            this.func_CPF = "";
            this.func_RG = "";
            this.func_CEP = "";
            this.func_Endereco = "";
            this.func_Cidade = "";
            this.func_Estado = "";
            this.func_Email = "";
            this.func_Telefone = "";
        }

        public modelFunc(int cod, string nome, string cpf, string rg, 
            string cep, string end, string cid, string est, string email, 
            string tel)
        {
            this.func_Cod = cod;
            this.func_Nome = nome;
            this.func_CPF = cpf;
            this.func_RG = rg;
            this.func_CEP = cep;
            this.func_Endereco = end;
            this.func_Cidade = cid;
            this.func_Estado = est;
            this.func_Email = email;
            this.func_Telefone = tel;
        }

        private int func_Cod;

        public int funcCod
        {
            get { return this.func_Cod; }
            set { this.func_Cod = value; }

        }
       
        private string func_Nome;

        public string funcNome
        {
            get { return this.func_Nome; }
            set { this.func_Nome = value; }
        }

        private string func_CPF;

        public string funcCPF
        {
            get { return this.func_CPF; }
            set { this.func_CPF = value; }
        }

        private string func_Endereco;

        public string funcEndereco
        {
            get { return this.func_Endereco; }
            set { this.func_Endereco = value; }
        }

        private string func_Cidade;

        public string funcCidade
        {
            get { return this.func_Cidade; }
            set { this.func_Cidade = value; }
        }

        private string func_Telefone;

        public string funcTelefone
        {
            get { return this.func_Telefone; }
            set { this.func_Telefone = value; }
        }

        private string func_RG;

        public string funcRG
        {
            get { return this.func_RG; }
            set { this.func_RG = value; }
        }

        private string func_Email;

        public string funcEmail
        {
            get { return this.func_Email; }
            set { this.func_Email = value; }
        }

        private string func_CEP;

        public string funcCEP
        {
            get { return this.func_CEP; }
            set { this.func_CEP = value; }
        }

        private string func_Estado;
        public string funcEstado
        {
            get { return this.func_Estado; }
            set { this.func_Estado = value; }
        }
    }
}
