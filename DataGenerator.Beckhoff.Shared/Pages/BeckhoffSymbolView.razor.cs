using BeckhoffResolver.PLCSymbol;
using Microsoft.AspNetCore.Components;

namespace DataGenerator.Beckhoff.Shared.Pages
{
    public partial class BeckhoffSymbolView
    {
        [Parameter]
        public SymbolInfo CurrentSymbol { get; set; } = default!;

        private SymbolInfoWrapper symbol = default!;

        protected override Task OnParametersSetAsync()
        {
            if(symbol is not null)
            {
                symbol.IsInUseChanged -= Symbol_IsInUseChanged;
            }
            symbol = new SymbolInfoWrapper(CurrentSymbol);
            symbol.IsInUseChanged += Symbol_IsInUseChanged;
            return base.OnParametersSetAsync();
        }
        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            return base.OnAfterRenderAsync(firstRender);
        }

        private void Symbol_IsInUseChanged(object? sender, bool e)
        {
            InvokeAsync(StateHasChanged);
        }
    }
}