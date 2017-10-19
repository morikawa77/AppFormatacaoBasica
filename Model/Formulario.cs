using System;
namespace AppFormatacaoBasica.Model
{
    public class Formulario
    {
        public Formulario()
        {
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public Int32 Telefone { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public TimeSpan HoraNascimento { get; set; }
        public string Informacao { get; set; }
        public Double Preco { get; set; }
        public bool Inativo { get; set; }
    }
}
