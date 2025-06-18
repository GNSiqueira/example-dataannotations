using System.Reflection;

namespace Teste_Data_Annotation.Acoes;

[AttributeUsage(AttributeTargets.Property)]
public abstract class BaseAttribute : Attribute
{
    // Método que toda ação deverá implementar.
    // Ele recebe informações da propriedade onde a anotação foi colocada.
    public abstract void Executar(PropertyInfo propriedade, object objetoPai);
}