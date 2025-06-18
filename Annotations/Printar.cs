using System;
using System.Reflection;
using Teste_Data_Annotation.Acoes; // Importando nossa classe base

namespace Teste_Data_Annotation.MinhasAcoes; 

public class Printar : BaseAttribute
{
    public override void Executar(PropertyInfo propriedade, object objetoPai)
    {
        // Pega o valor da propriedade no objeto (ex: o valor de 'Id' no objeto 'teste')
        object? valorDaPropriedade = propriedade.GetValue(objetoPai);

        propriedade.SetValue(objetoPai, 8888);
        
        Console.WriteLine("--- Ação [Printar] Executada ---");
        Console.WriteLine($"Propriedade: {propriedade.Name}");
        Console.WriteLine($"Valor da Propriedade: {valorDaPropriedade}");
        Console.WriteLine("---------------------------------");
    }
}
