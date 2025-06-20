using System;
using System.Reflection;
using AkariBeauty.Objects.Dtos.DataAnnotations.Base;

namespace Teste_Data_Annotation.MinhasAcoes; 

public class PrintarAttribute : BaseAnnotation
{


    public override void Execute()
    {
        if (Parameters != null && Parameters.Any()) 
            foreach (var item in Parameters)
            {
                Console.WriteLine(item);
            }

        Console.WriteLine("--- Ação [Printar] Executada ---");
        Console.WriteLine($"Propriedade: {Value}");

        Console.WriteLine($"Depois da alteração");
        Value = 999;
        Console.WriteLine($"Propriedade: {Value}");
        Console.WriteLine("---------------------------------");
    }
}