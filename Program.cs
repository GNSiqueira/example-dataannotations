using Teste_Data_Annotation.DTOs;
using Teste_Data_Annotation.Processadores;

public class Program
{
    public static void Main()
    {
        // 1. Cria uma instância do seu objeto
        var meuTeste = new Teste { Id = 123, Nome = "Objeto Exemplo" };

        Console.WriteLine("Objeto criado. Nenhuma ação foi executada ainda.");
        Console.WriteLine("As anotações são apenas marcadores passivos.");

        // 2. Chama o processador. É ESTE PASSO que lê as anotações e executa as ações.
        ProcessadorDeAcoes.ExecutarAcoes(meuTeste);

        Console.WriteLine(meuTeste.Id);

        Console.WriteLine("\nProcessamento finalizado.");
    }
}