using MegaSena.Atributos;
using System.ComponentModel.DataAnnotations;

namespace MegaSena.Models
{
    public class MegaSenaViewModel
    {
        [CustomStringLengthValidation(5, 255)]
        public string Nome { get; set; }

        [CPFValidation]
        public string Cpf { get; set; }

        [Range(1, 60)]
        public int PrimeiroNro { get; set; }
        [Range(1, 60)]
        public int SegundoNro { get; set; }
        [Range(1, 60)]
        public int TerceiroNro { get; set; }
        [Range(1, 60)]
        public int QuartoNro { get; set; }
        [Range(1, 60)]
        public int QuintoNro { get; set; }
        [Range(1, 60)]
        public int SextoNro { get; set; }
        public DateTime DataJogo { get; set; }
    }
}
