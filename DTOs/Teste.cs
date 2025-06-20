using System.Runtime.InteropServices;
using Teste_Data_Annotation.MinhasAcoes;

namespace Teste_Data_Annotation.DTOs
{
    public class Teste
    {
        // Agora o compilador entende que [Printar] é a classe PrintarAttribute
        [ValidateQtdCaracters(5, 10, ErrorMessage = "Quantidade de caracteres inválida")]
        public int Id { get; set; }

        public string? Nome { get; set; }
        
    }
}