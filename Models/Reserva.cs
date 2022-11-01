namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (Suite.Capacidade >= hospedes.Count)
            {
                this.Hospedes = hospedes;
            }
            else
            {
                
                throw new Exception("Desculpe o número de hospedes excede a capacidade da suite!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = (decimal)DiasReservados * Suite.ValorDiaria;

            
            if (DiasReservados >= 10)
            {
                valor = valor * (decimal)0.9;
            }

            return valor;
        }
    }
}