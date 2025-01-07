namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string cargo { get; set;}
        DateTime dataAtual = DateTime.Now.AddDays(5);

    
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e sou {cargo}");
            
            Console.WriteLine($" hoje é {dataAtual.ToString("dd/MM/yyyy")}");
        }


    }
   
}