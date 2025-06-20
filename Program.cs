using Teste_Data_Annotation.DTOs;
using Teste_Data_Annotation.Processadores;

public class Program
{
    public static void Main()
    {
        var meuTeste = new Teste { Id = 123442555, Nome = "Objeto Exemplo" };

        ProcessadorDeAcoes.Executar(meuTeste);
    }
}