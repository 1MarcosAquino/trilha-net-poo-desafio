namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando...");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação...");
        }

        // tomei a liberdade de criar esse metodo estou ciente de que isso modifica o diagrama.
        // É que eu não vi o uso dessas propriedades. espero não ter feito besteira.  
        public void About()
        {
            Console.WriteLine("Sobre");
            Console.Write($"Modelo: {Modelo}, ");
            Console.Write($"IMEI: {IMEI}, ");
            Console.WriteLine($"Memoria: {Memoria}GB.");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}