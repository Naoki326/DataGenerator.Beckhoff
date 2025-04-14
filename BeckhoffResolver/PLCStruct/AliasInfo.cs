using System.Security.Principal;
using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCStruct
{
    public sealed class AliasInfo : AbstractPlcTypeInfo
    {
        public AliasInfo()
        {
        }
        public AliasInfo(string name, string nameSpace) : base(name, nameSpace, 1)
        {
        }
        public AliasInfo(string name, string nameSpace, string baseTypeName) : base(name, nameSpace, 1)
        {
            BaseTypeName = baseTypeName;
        }

        public IPlcTypeInfo BaseType { get; set; } = default!;

        public string BaseTypeName { get; set; } = default!;

        public override DataTypeEnum DataType => DataTypeEnum.Alias;

        public override string ToFieldString(string fieldName, int tabCount)
        {
            return "";
        }

        public override string ToPropertyString(string propertyName, int tabCount)
        {
            return "";
        }

        public override string ToResolveString(int tabCount)
        {
            return ClassDefineHelper.GetTabs(tabCount) + @"using {Name} = {BaseTypeName};";
        }
    }


}
