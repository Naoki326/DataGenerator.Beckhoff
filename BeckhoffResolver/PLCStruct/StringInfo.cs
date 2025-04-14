using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCStruct
{
    public class StringInfo : AbstractPlcTypeInfo
    {
        public StringInfo()
        {
        }

        public StringInfo(string name, string nameSpace, int size) : base(name, nameSpace, size)
        {
        }

        public override DataTypeEnum DataType => DataTypeEnum.String;

        public bool TryGetMarshalAttribute(/*[NotNullWhen(true)]*/ out string? marshalInfo)
        {
            if(Size > 0)
            {
                marshalInfo = "UnmanagedType.ByValTStr, SizeConst = " + Size;
                return true;
            }
            marshalInfo = null;
            return false;
        }

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
