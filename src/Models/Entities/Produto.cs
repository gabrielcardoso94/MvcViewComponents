using System.ComponentModel.DataAnnotations;

namespace src.Models.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        [Display(Name = "Nome do produto")]
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        [Display(Name = "Valor unitário")]
        public double Valor { get; set; }

        public Produto()
        {            
        }

        public Produto(int id, string nome, int quantidade, double valor)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }

        public double Total()
        {
            return Valor * Quantidade;
        }
    }
}