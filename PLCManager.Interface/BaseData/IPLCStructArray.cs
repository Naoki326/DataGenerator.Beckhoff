using System.Collections.Generic;

namespace PlcCore.Data
{
    /// <summary>
    /// PLC内部的基础数据数组的结构体封装
    /// 为了实现64位程序适配32位的结构体
    /// 必须对基本数据的数组再封装一层结构体
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPLCStructArray<T> : IEnumerable<T>
    {
        T this[int index] { get; set; }

        int Length { get; }
    }

}
