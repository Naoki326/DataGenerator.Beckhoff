using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BeckhoffResolver.PLCStruct;
using TwinCAT.TypeSystem;
using static System.Net.Mime.MediaTypeNames;

namespace BeckhoffResolver.PLCStructModel
{

    public abstract class AbstractPlcTypeInfo : IPlcTypeInfo
    {
        public AbstractPlcTypeInfo()
        {
        }

        public AbstractPlcTypeInfo(string name, string nameSpace, int size)
        {
            Name = name;
            NameSpace = nameSpace;
            Size = size;
        }

        public string Name { get; set; } = string.Empty;

        public string NameSpace { get; set; } = string.Empty;

        public virtual string? TypeComment { get; set; } = string.Empty;

        protected string GetComment(int tabCount)
        {
            StringBuilder sb = new StringBuilder();
            if (TypeComment is not null)
            {
                foreach (var commentLine in Regex.Split(TypeComment, "\r\n|\r|\n"))
                {
                    sb.AppendLine(ClassDefineHelper.GetTabs(tabCount) + $"//{commentLine}");
                }
            }
            return sb.ToString();
        }

        public virtual HashSet<PlcAttributeInfo>? TypeAttributes { get; set; } = null;

        protected string GetAttributes(int tabCount)
        {
            StringBuilder sb = new StringBuilder();
            if (TypeAttributes is not null)
            {
                foreach (var attribute in TypeAttributes)
                {
                    sb.AppendLine(ClassDefineHelper.GetTabs(tabCount) + $"//" + attribute.ToAttributeString());
                }
            }
            return sb.ToString();
        }

        public int Size { get; set; }

        public abstract DataTypeEnum DataType { get; }

        private IPlcTypeInfo GetBaseType(IPlcTypeInfo info)
        {
            if (info is AliasInfo aliasInfo)
            {
                return GetBaseType(aliasInfo.BaseType);
            }
            return info;
        }

        public IPlcTypeInfo GetBaseType()
        {
            return GetBaseType(this);
        }

        public abstract string ToResolveString(int tabCount);

        public abstract string ToFieldString(string fieldName, int tabCount);

        public abstract string ToPropertyString(string propertyName, int tabCount);

    }

}
