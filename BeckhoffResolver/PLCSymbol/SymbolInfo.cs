using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCSymbol
{
    public class SymbolInfo
    {
        public virtual HashSet<PlcAttributeInfo>? SymbolAttributes { get; set; }

        public virtual string TypeNameFromPLC { get; set; } = string.Empty;

        public virtual string InstanceName { get; set; } = string.Empty;

        public virtual uint IndexGroup { get; set; }

        public virtual uint IndexOffset { get; set; }

        public virtual int Size { get; set; }

        public virtual HashSet<SymbolInfo> SubSymbols { get; set; } = [];


        public IEnumerable<SymbolInfo> GetUsedSubSymbols()
        {
            return this.GetSubSymbols().Where(p => p.IsInUse);
        }

        public IEnumerable<SymbolInfo> GetSubSymbols()
        {
            return SubSymbols.OrderBy(s => s.IndexGroup).ThenBy(s => s.IndexOffset);
        }

        public virtual bool IsInUse{get;set;} = true;

        public virtual bool IsArray { get; set; } = false;

        public override bool Equals(object? obj)
        {
            if(obj is SymbolInfo other
                && other.InstanceName == InstanceName)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (TypeNameFromPLC + InstanceName).GetHashCode();
        }
    }
}
