namespace PrimeiraApi.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }


        public string Nome { get; set; }

        
        // Construtor
        public Pessoa(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
