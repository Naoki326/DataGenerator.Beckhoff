using System.Text.RegularExpressions;

namespace BeckhoffResolver.PLCTree
{
    public static class FileNameHelper
    {
        public static string MakeValidFileName(this string input)
        {
            // 定义无效字符的正则表达式
            string invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
            string invalidReStr = string.Format(@"[{0}]+", invalidChars);

            // 去除无效字符
            string sanitized = Regex.Replace(input, invalidReStr, "_");

            // 修剪空格
            sanitized = sanitized.Trim();

            // 检查是否是保留名称
            string[] reservedNames = { "CON", "PRN", "AUX", "NUL", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9" };
            foreach (string reservedName in reservedNames)
            {
                if (sanitized.Equals(reservedName, StringComparison.OrdinalIgnoreCase))
                {
                    sanitized = "_" + sanitized;
                    break;
                }
            }

            // 限制长度
            if (sanitized.Length > 255)
            {
                sanitized = sanitized.Substring(0, 255);
            }

            return sanitized;
        }
    }
}