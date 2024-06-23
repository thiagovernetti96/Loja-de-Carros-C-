namespace Loja_de_Carros.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DataAdmissao { get; set; }

        public int Matricula { get; set; }

        public int Salario { get; set; }


        public double Calcular_Comissão(Carro carro)
        {
            double comissao = 0.2;

            double CalculodaComissao = carro.Preco * comissao;

            return CalculodaComissao;

        }

    }


}
