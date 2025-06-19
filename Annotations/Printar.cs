using System;
using System.Reflection;
using AkariBeauty.Objects.Dtos.DataAnnotations.Base;

namespace Teste_Data_Annotation.MinhasAcoes; 

public class Printar : BaseAnnotation
{
    public override void Executar()
    {
        // Pega o valor da propriedade no objeto (ex: o valor de 'Id' no objeto 'teste')
        

        Console.WriteLine("--- Ação [Printar] Executada ---");
        Console.WriteLine($"Propriedade: {Value}");

        Console.WriteLine($"Depois da alteração");
        Value = 999;
        Console.WriteLine($"Propriedade: {Value}");
        Console.WriteLine("---------------------------------");
    }
}
