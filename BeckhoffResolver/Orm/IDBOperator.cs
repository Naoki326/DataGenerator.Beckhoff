using System.Text.Json.Serialization;

namespace ORM
{

    public interface IDBOperator
    {
        void SetPath(string savePathArg);

        //增加一个自定义Converter
        void AddConverter(JsonConverter item);

        //增加一种基类—派生类型的解析
        void AddDerivedRelate<T, U>() where U : class, T where T : class;

        //增加一种基类—派生类型的解析
        void AddDerivedRelate(Type baseType, Type derivedType);

        T? DeSerialize<T>(string json) where T : class;

        string Serialize<T>(T data) where T : class;

        //获取数据
        T GetData<T>() where T : class;
        bool TryGetData<T>(out T data) where T : class;

        //获取数据
        object GetData(Type type);
        bool TryGetData(Type type, out object data);

        //获取数据
        void SetData(Type type, object data);
        bool TrySetData(Type type, object data);

        //设置数据
        void SetData<T>(T data) where T : class;
        bool TrySetData<T>(T data) where T : class;

    }
}
