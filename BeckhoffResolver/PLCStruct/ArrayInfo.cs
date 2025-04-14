using System.Text;
using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCStruct
{
    //只考虑一维数组
    public sealed class ArrayInfo : AbstractPlcTypeInfo
    {
        public ArrayInfo()
        {
        }
        public ArrayInfo(string name, string nameSpace, int size) : base(name, nameSpace, size)
        {
        }

        public ArrayInfo(string name, string nameSpace, int size, string elementTypeName, int arrayLength) : base(name, nameSpace, size)
        {
            ArrayLength = arrayLength;
            ArrayInnerTypeName = elementTypeName;
            if (name.StartsWith("ARRAY [0"))
            {
                IsStartFromZero = true;
            }
            else if (name.StartsWith("ARRAY [1"))
            {
                IsStartFromZero = false;
            }
        }

        public bool IsStartFromZero { get; set; }

        public int ArrayLength { get; set; }

        public override DataTypeEnum DataType => DataTypeEnum.Array;

        public string ArrayInnerTypeName { get; set; } = string.Empty;
        public IPlcTypeInfo? ArrayInnerType { get; set; }

        public override string ToFieldString(string fieldName, int tabCount)
        {
            StringBuilder sb = new StringBuilder();
            if (ArrayInnerType.DataType == DataTypeEnum.Primitive)
            {
                if (ArrayInnerType.Name == "bool")
                {
                    sb.Append(ClassDefineHelper.GetTabs(tabCount) + $"[MarshalAs(UnmanagedType.ByValArray, SizeConst = {ArrayLength}, ArraySubType = UnmanagedType.I1]");
                }
                else
                {
                    sb.Append(ClassDefineHelper.GetTabs(tabCount) + $"[MarshalAs(UnmanagedType.ByValArray, SizeConst = {ArrayLength}]");
                }
            }
            else
            {
                sb.Append(ClassDefineHelper.GetTabs(tabCount) + $"[MarshalAs(UnmanagedType.ByValArray, SizeConst = {ArrayLength}]");
            }
            sb.Append(ClassDefineHelper.GetTabs(tabCount) + $"public {ArrayInnerType.Name}[] {fieldName} {{ get; set; }}");
            sb.AppendLine();
            return sb.ToString();
        }

        public override string ToPropertyString(string propertyName, int tabCount)
        {
            throw new NotImplementedException();
        }

        public override string ToResolveString(int tabCount)
        {
            return "";
        }
    }

}
