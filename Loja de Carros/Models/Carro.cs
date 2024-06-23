

namespace Loja_de_Carros.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }

        public string Marca { get; set; }

        public DateTime AnoFabricação { get; set; }

        public DateTime AnoModelo { get; set; }

        public string Chassi { get; set; }

        public int Preco { get; set; }
    }
}
