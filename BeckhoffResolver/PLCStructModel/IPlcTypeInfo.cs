
namespace BeckhoffResolver.PLCStructModel
{
    public interface IPlcTypeInfo
    {
        DataTypeEnum DataType { get; }
        string Name { get; }
        string NameSpace { get; }
        int Size { get; }
        HashSet<PlcAttributeInfo>? TypeAttributes { get; set; }
        string? TypeComment { get; set; }

        string ToFieldString(string fieldName, int tabCount);
        string ToPropertyString(string propertyName, int tabCount);
        string ToResolveString(int tabCount);

        IPlcTypeInfo GetBaseType();
    }
}