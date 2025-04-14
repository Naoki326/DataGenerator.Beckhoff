using BeckhoffResolver.PLCStructModel;
using BeckhoffResolver.PLCSymbol;

namespace DataGenerator.Beckhoff.Shared.Pages
{
    public class SymbolInfoWrapper : SymbolInfo
    {
        public SymbolInfoWrapper(SymbolInfo symbol)
        {
            this.symbol = symbol;
        }

        private SymbolInfo symbol;

        public override HashSet<PlcAttributeInfo>? SymbolAttributes { get => symbol.SymbolAttributes; set => symbol.SymbolAttributes = value; }

        public override string TypeNameFromPLC { get => symbol.TypeNameFromPLC; set => symbol.TypeNameFromPLC = value; }

        public override string InstanceName { get => symbol.InstanceName; set => symbol.InstanceName = value; }

        public override uint IndexGroup { get => symbol.IndexGroup; set => symbol.IndexGroup = value; }

        public override uint IndexOffset { get => symbol.IndexOffset; set => symbol.IndexOffset = value; }

        public override int Size { get => symbol.Size; set => symbol.Size = value; }

        public override HashSet<SymbolInfo> SubSymbols { get => symbol.SubSymbols; set => symbol.SubSymbols = value; }


        public override bool IsArray { get => symbol.IsArray; set => symbol.IsArray = value; }


        public override bool IsInUse
        {
            get => symbol.IsInUse;
            set
            {
                symbol.IsInUse = value;
                IsInUseChanged?.Invoke(this, value);
                SetChild(this);
            }
        }

        public event EventHandler<bool>? IsInUseChanged;

        void SetChild(SymbolInfo node)
        {
            foreach (var child in node.GetSubSymbols())
            {
                child.IsInUse = IsInUse;
                SetChild(child);
            }
        }
    }
}
