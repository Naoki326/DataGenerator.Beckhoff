
namespace BeckhoffResolver.PLCStructModel
{
    public sealed class PlcAttributeInfo
    {
        public PlcAttributeInfo()
        {
        }

        public PlcAttributeInfo(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// 当前结构同名称的Attribute不可重复
        /// </summary>
        public string Name { get; init; } = string.Empty;

        public string Value { get; init; } = string.Empty;

        public override bool Equals(object? obj)
        {
            return obj is PlcAttributeInfo objInfo && this.Name == objInfo.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public string ToAttributeString()
        {
            return $"Attribute from PLC:{Name} = {Value}";
        }
    }


}
