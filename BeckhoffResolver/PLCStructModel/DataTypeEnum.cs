using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeckhoffResolver.PLCStructModel
{
    public enum DataTypeEnum
    {
        //
        // 摘要:
        //     Uninitialized / NotProcessed (0)
        None = 0,
        //
        // 摘要:
        //     Simple / Base Data Type (1)
        Primitive = 1,
        //
        // 摘要:
        //     Alias data type (2)
        Alias = 2,
        //
        // 摘要:
        //     Enumeration data type (3)
        Enum = 3,
        //
        // 摘要:
        //     Array data type (4)
        Array = 4,
        //
        // 摘要:
        //     Structure data type (5)
        Struct = 5,
        //
        // 摘要:
        //     Function block (POU) (6)
        FunctionBlock = 6,
        //
        // 摘要:
        //     Program (POU) (7)
        Program = 7,
        //
        // 摘要:
        //     Function (POU) (8)
        Function = 8,
        //
        // 摘要:
        //     SubRange (9)
        SubRange = 9,
        //
        // 摘要:
        //     Fixed length string (10)
        String = 10,
        //
        // 摘要:
        //     Bitset (12)
        Bitset = 12,
        //
        // 摘要:
        //     Pointer type (13)
        Pointer = 13,
        //
        // 摘要:
        //     Union type (14)
        Union = 14,
        //
        // 摘要:
        //     Reference type (15)
        Reference = 15,
        //
        // 摘要:
        //     The interface
        Interface = 16
    }
}
