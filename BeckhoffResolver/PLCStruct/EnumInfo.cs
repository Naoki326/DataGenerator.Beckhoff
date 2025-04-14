using System.Text;
using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCStruct
{
    public sealed class EnumKV
    {
        public EnumKV()
        {
        }

        public EnumKV(string key, int value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }

        public int Value { get; set; }
    }

    public sealed class EnumInfo : AbstractPlcTypeInfo
    {
        public EnumInfo()
        {
        }
        public EnumInfo(string name, string nameSpace, int size) : base(name, nameSpace, size)
        {
        }
        public EnumInfo(string name, string nameSpace, int size, string baseTypeName, Dictionary<string, int> enumDict) : base(name, nameSpace, size)
        {
            BaseTypeName = baseTypeName;
            Values = enumDict.Select(p => new EnumKV(p.Key, p.Value)).ToList();
        }

        public string BaseTypeName { get; set; } = default!;

        public IPlcTypeInfo BaseType { get; set; } = default!;

        public List<EnumKV> Values { get; set; } = default!;

        public override DataTypeEnum DataType => DataTypeEnum.Enum;

        public override string ToFieldString(string fieldName, int tabCount)
        {
            throw new NotImplementedException();
        }

        public override string ToPropertyString(string propertyName, int tabCount)
        {
            throw new NotImplementedException();
        }

        public override string ToResolveString(int tabCount)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ClassDefineHelper.GetTabs(tabCount) + $"TYPE {Name} : ENUMERATION OF");
            sb.AppendLine("END_TYPE");
            return sb.ToString();
        }
    }


}
