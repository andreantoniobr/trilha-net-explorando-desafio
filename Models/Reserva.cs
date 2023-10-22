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
            //No desafio pede uma Exception
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hospedes não pode ultrapassar a capacidade da suite.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            if (suite != null)
            {
                Suite = suite;
            }
            else
            {
                Console.WriteLine("A suite não pode ser cadastrada.");
            }            
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Cálculo: DiasReservados X Suite.ValorDiaria            
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%            
            if (DiasReservados >= 10)
            {
                valor  *= 0.9m;
            }

            return valor;
        }
    }
}