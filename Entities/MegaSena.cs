using MegaSena.Atributos;
using System.ComponentModel.DataAnnotations;

namespace MegaSena.Entities
{
    public class MegaSena
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int PrimeiroNro { get; set; }
        public int SegundoNro { get; set; }
        public int TerceiroNro { get; set; }
        public int QuartoNro { get; set; }
        public int QuintoNro { get; set; }
        public int SextoNro { get; set; }
        public DateTime DataJogo { get; set; }

        public bool NumerosValidos()
        {
            if (PrimeiroNro == SegundoNro || PrimeiroNro == TerceiroNro || PrimeiroNro == QuartoNro || PrimeiroNro == QuintoNro || PrimeiroNro == SextoNro ||
                SegundoNro == TerceiroNro || SegundoNro == QuartoNro || SegundoNro == QuintoNro || SegundoNro == SextoNro ||
                TerceiroNro == QuartoNro || TerceiroNro == QuintoNro || TerceiroNro == SextoNro ||
                QuartoNro == QuintoNro || QuartoNro == SextoNro ||
                QuintoNro == SextoNro)
                return false;
            return true;
        }
        public void atualizarData()
        {
            DataJogo = DateTime.Now;
        }
    }
}
