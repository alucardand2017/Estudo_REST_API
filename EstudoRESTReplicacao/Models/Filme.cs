using System.ComponentModel.DataAnnotations;

namespace EstudoRESTReplicacao.Models
{
    public class Filme
    {
        private const int duracaoMinima1 = 1;
        private const int duracaoMaxima1 = 600;


        public int Id { get; set; }

        [Required(ErrorMessage ="Titulo do filme é obrigatorio!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Preencha o campo Genero.")]
        public string Genero { get; set; }
        [Required(ErrorMessage ="Preencha o campo Diretor")]
        public string Diretor { get; set; }
        [Range(duracaoMinima1, duracaoMaxima1, ErrorMessage = "Escolha valores entre e 1 e 600")]
        public int Duracao  { get; set; }
        public override string ToString()
        {
            return Titulo + " / " + Genero + " / " + Diretor + " / " + Duracao.ToString();   
        }
    }

    

}
