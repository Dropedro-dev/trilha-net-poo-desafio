namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string? _numero;
        public string? Numero
        {
            get => _numero;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _numero = null;
                    throw new ArgumentException("O seu número está nulo ou vazio.");
                }
                else if (value.Length < 8 || value.Length > 15)
                {
                    _numero = null;
                    throw new ArgumentException("O seu número deve ter de 9 a 14 dígitos.");
                }
                else if (!value.All(char.IsDigit))
                {
                    _numero = null;
                    throw new ArgumentException("O seu número deve conter apenas dígitos.");
                }
                else
                {
                    _numero = value;
                }
                
             }
        }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            if (!string.IsNullOrEmpty(Numero))
                Console.WriteLine($"O numero : {Numero} está Ligando...");            
        }

        public void ReceberLigacao()
        {
            if (!string.IsNullOrEmpty(Numero))
                Console.WriteLine($"Recebendo ligação no número: {Numero}");            
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}