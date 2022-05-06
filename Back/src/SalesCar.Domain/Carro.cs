namespace SalesCar.Domain
{
    public class Carro    
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Cor { get; set; } 
        public string AnoModelo { get; set; }
        public string AnoFabricacao { get; set; }
        public string Marca { get; set; }
        public string Empresa { get; set; } 
        public double Preco { get; set; }   
        public string Modelo { get; set; }
        public double MargemIdeal { get; set; }
        public double MargemMinima { get; set; }
        
    }
}