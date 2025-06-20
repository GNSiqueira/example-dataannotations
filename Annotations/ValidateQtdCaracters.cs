
using AkariBeauty.Objects.Dtos.DataAnnotations.Base;

namespace Teste_Data_Annotation.MinhasAcoes;

public class ValidateQtdCaractersAttribute : BaseAnnotation
{

    public ValidateQtdCaractersAttribute(params object[]? parameters) : base(parameters)
    {
        if (parameters is null)
            throw new ArgumentNullException("Essa funcão precisa de parametros");

    }

    public override void Execute()
    {

        var qtdValor = Value?.ToString()?.Length;

        if (Parameters != null)
        {
            foreach (var item in Parameters)
            {
                if (qtdValor == (int)item)
                {
                    Console.WriteLine($"O campo {Value} alcançou a quantidade minima de caracteres.");
                    return;
                }
            }
        }

        Console.WriteLine($"O campo {Value} não alcançou as quantidades minimas de caracteres. Quantidade aceitavel: {string.Join(", ", Parameters)}");
    }
}
