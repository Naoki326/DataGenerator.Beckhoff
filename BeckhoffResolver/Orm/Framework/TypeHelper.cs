using System.Text;

namespace ORM.Framework
{
    public static class TypeHelper
    {
        public static string GetFriendlyTypeName(this Type type)
        {
            if (!type.IsGenericType)
                return type.Name;

            StringBuilder sb = new StringBuilder();
            string name = type.Name;
            int backtickIndex = name.IndexOf('`');
            if (backtickIndex > 0)
            {
                name = name.Substring(0, backtickIndex);
            }

            sb.Append(name);
            sb.Append('[');
            Type[] args = type.GetGenericArguments();
            for (int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                    sb.Append("_");
                sb.Append(args[i].GetFriendlyTypeName());
            }
            sb.Append(']');
            return sb.ToString();
        }
    }
}
