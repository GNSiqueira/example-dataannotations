using System.Runtime.InteropServices;
using Teste_Data_Annotation.MinhasAcoes; // Precisa do 'using' para encontrar o [PrintarAttribute]

namespace Teste_Data_Annotation.DTOs
{
    public class Teste
    {
        // Agora o compilador entende que [Printar] é a classe PrintarAttribute
        [Printar]
        public int Id { get; set; }

        public string? Nome { get; set; }
    }
}