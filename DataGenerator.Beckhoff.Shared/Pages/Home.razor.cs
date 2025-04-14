using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BeckhoffResolver.PLCSymbol;
using BeckhoffResolver.PLCTree;
using Masa.Blazor;
using Microsoft.AspNetCore.Components;

namespace DataGenerator.Beckhoff.Shared.Pages
{
    public partial class Home
    {
        DataGeneratorView dataGenerator;

        int step = 1;
        StringNumber Step
        {
            get => step;
            set => step = value.ToInt32();
        }
        string currentTitle
        {
            get => step switch
            {
                1 => "Generator",
                2 => "Tester",
                _ => "Generator"
            };
        }

    }
}
