namespace API_Postgres.Business.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}