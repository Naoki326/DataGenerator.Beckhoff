using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BeckhoffResolver.PLCStructModel
{
    internal static class ClassDefineHelper
    {
        public static string GetTabs(this int tabCount)
        {
            return Enumerable.Range(0, tabCount).Aggregate("", (sum, i) => { return sum + "\t"; });
        }

        public static string ConvertFieldDefinition(this string definition)
        {
            return $"{definition.Replace('.', '_')}"; // 替换 '.' 为 '_'，以防止非法字符
        }

        public static bool ConvertArrayDefinition(this string definition, /*[NotNullWhen(true)]*/out string? result)
        {
            // 使用正则表达式提取数组元素类型
            var match = Regex.Match(definition, @"ARRAY\s*\[\d+\.\.\d+\]\s*OF\s*(.+)");
            if (match.Success)
            {
                string elementType = match.Groups[1].Value.Trim();
                result =  $"{elementType.Replace('.', '_')}[]"; // 替换 '.' 为 '_'，以防止非法字符
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        public static string CapitalizeFirstLetter(this string input)
        {
            switch(input)
            {
                case "uint":
                    return "UInt";
                case "ushort":
                    return "UShort";
                case "ulong":
                    return "ULong";
                case "sbyte":
                    return "SByte";
            }

            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static string WrapperSubffix(this string typeName)
        {
            if (typeName.ConvertArrayDefinition(out string? name))
            {
                return name + "Array" + "Wrapper";
            }
            return typeName.ConvertFieldDefinition() + "Wrapper";
        }

        public static string NoWrapperSubffix(this string typeName)
        {
            if (typeName.ConvertArrayDefinition(out string? name))
            {
                return name + "Array";
            }
            return typeName.ConvertFieldDefinition();
        }

        public static string ToCSharpTypeName(this string plcType)
        {
            switch (plcType)
            {
                case "BIT": return "bool";
                case "BOOL": return "bool";
                case "BYTE": return "byte";
                case "SBYTE": return "sbyte";
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
            return plcType;
        }
    }
}
