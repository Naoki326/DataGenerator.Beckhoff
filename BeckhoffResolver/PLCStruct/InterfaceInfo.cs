using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCStruct
{
    public class InterfaceInfo : AbstractPlcTypeInfo
    {
        public InterfaceInfo()
        {
        }

        public InterfaceInfo(string name, string nameSpace, int size) : base(name, nameSpace, size)
        {
        }

        public override DataTypeEnum DataType => DataTypeEnum.Interface;

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
            throw new NotImplementedException();
        }
    }
}