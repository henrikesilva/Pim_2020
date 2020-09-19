namespace CourtageCoin.Domain.Entities
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }

        public Funcionario funcionario { get; set; }
        public Cliente cliente { get; set; }
    }
}
