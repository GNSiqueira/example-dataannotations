using System.Reflection;

namespace AkariBeauty.Objects.Dtos.DataAnnotations.Base;

[AttributeUsage(AttributeTargets.Property)]
public abstract class BaseAnnotation : Attribute
{

    protected object Value
    {
        get => GetValue();
        set => SetValue(value);
    }

    private PropertyInfo _property;
    private object _value;

    public void Initizlize(PropertyInfo property, object value)
    {
        _property = property;
        _value = value;
        Console.WriteLine("Executou o construtor BaseAnnotation");
    }

    public abstract void Executar();

    private object GetValue()
    {
        return _property.GetValue(_value);
    }

    protected void SetValue(object newValue)
    {
        _property.SetValue(_value, newValue);
    }
}