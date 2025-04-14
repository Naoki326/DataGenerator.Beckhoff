using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCStruct
{
    public sealed class FieldInfo
    {
        public FieldInfo(int offset, string instanceName, IPlcTypeInfo plcTypeInfo,string typeName = "")
        {
            Offset = offset;
            InstanceName = instanceName;
            PlcTypeInfo = plcTypeInfo;
            TypeName = typeName;
        }

        public int Offset { get; set; }
        public string InstanceName { get; set; }

        public string TypeName { get; set; }

        [JsonIgnore]
        public IPlcTypeInfo PlcTypeInfo { get; set; }
    }

    public sealed class StructInfo : AbstractPlcTypeInfo
    {
        public StructInfo() 
        {
        }

        public StructInfo(string name, string nameSpace, int size) : base(name, nameSpace, size)
        {
        }

        public override DataTypeEnum DataType => DataTypeEnum.Struct;

        public List<FieldInfo> Fields { get; set; } = [];

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
