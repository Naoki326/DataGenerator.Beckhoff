using System;
using System.Collections.Generic;
using System.Text;

namespace PlcCore.Data
{
    internal static class BaseDataParentHelper
    {
        public static void SetParent(this BaseData node)
        {
            foreach (var child in node.Children)
            {
                if (child is BaseData childNode)
                {
                    childNode.Parent = node;
                    childNode.SetParent();
                }
            }
        }

        public static void SetInit(this BaseData node)
        {
            foreach (var child in node.Children)
            {
                if (child is BaseData childNode)
                {
                    childNode.Init();
                    childNode.SetInit();
                }
            }
        }
    }
}
