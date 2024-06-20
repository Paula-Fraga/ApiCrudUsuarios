namespace ApiCrudUsuarios.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int? Idade { get; set; }
        public string? Email { get; set; }
        public char? Sexo { get; set; }
    }
}
