using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCStruct
{
    public class PointerInfo : AbstractPlcTypeInfo
    {
        public PointerInfo()
        {
        }

        public PointerInfo(string name, string nameSpace, int size) : base(name, nameSpace, size)
        {
        }

        public override DataTypeEnum DataType => DataTypeEnum.Pointer;

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
