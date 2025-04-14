using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCStruct
{
    public class ReferenceInfo : AbstractPlcTypeInfo
    {
        public ReferenceInfo()
        {
        }

        public ReferenceInfo(string name, string nameSpace, int size) : base(name, nameSpace, size)
        {
        }

        public override DataTypeEnum DataType => DataTypeEnum.Reference;

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
