using System.Diagnostics.CodeAnalysis;
using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCStruct
{
    public sealed class PrimitiveInfo : AbstractPlcTypeInfo
    {
        public PrimitiveInfo()
        {
        }

        public PrimitiveInfo(string name, string nameSpace, int size) : base(name, nameSpace, size)
        {
        }

        public override DataTypeEnum DataType => DataTypeEnum.Primitive;

        public string GetCSharpName()
        {
            switch (Name)
            {
                case "BIT": return "bool";
                case "BOOL": return "bool";
                case "BYTE": return "byte";
                case "SINT": return "sbyte";
                case "USINT": return "byte";

                case "WORD": return "short";
                case "INT": return "short";
                case "UINT": return "ushort";

                case "DWORD": return "int";
                case "DINT": return "int";
                case "UDINT": return "uint";

                case "LWORD": return "long";
                case "LINT": return "long";
                case "ULINT": return "ulong";

                case "REAL": return "float";
                case "LREAL": return "double";

                case "TIME": return "uint";
                case "TOD": return "uint";
                case "DATE": return "uint";
                case "DT": return "uint";
            }

            switch (Size)
            {
                case 1:
                    return "byte";
                case 2:
                    return "short";
                case 4:
                    return "int";
                case 8:
                    return "long";
                default:
                    return $"unknown_type{Name}";
            }
        }
        public bool TryGetMarshalAttribute(/*[NotNullWhen(true)]*/ out string? marshalInfo)
        {
            marshalInfo = "";
            switch (Name)
            {
                case "BIT":
                    marshalInfo = "UnmanagedType.I1";
                    return true;
                case "BOOL":
                    marshalInfo = "UnmanagedType.I1";
                    return true;

                case "TIME":
                case "TOD":
                case "DATE":
                case "DT":
                    marshalInfo = "UnmanagedType.U4";
                    return true;
            }
            if (DataType == DataTypeEnum.String)
            {
                marshalInfo = "UnmanagedType.ByValTStr, SizeConst = " + Size;
                return true;
            }
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