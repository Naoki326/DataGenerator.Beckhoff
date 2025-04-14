using System.Text.Json.Serialization;

namespace ORM.Framework
{

    public abstract class AbstractDBOperator : IDBOperator
    {
        public abstract T GetData<T>() where T : class;
        public abstract void SetData<T>(T data) where T : class;

        public bool TryGetData<T>(out T data) where T : class
        {
            try
            {
                data = GetData<T>();
                return true;
            }
            catch (Exception)
            {
                data = default!;
                return false;
            }
        }

        public bool TrySetData<T>(T data) where T : class
        {
            try
            {
                SetData(data);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected string savePath = default!;

        protected AbstractDBOperator(string savePathArg)
        {
            savePath = savePathArg;
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
        }

        public void SetPath(string savePathArg)
        {
            savePath = savePathArg;
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
        }

        protected virtual string SaveName<T>() => Path.Combine(savePath, typeof(T).GetFriendlyTypeName());
        protected virtual string SaveName<T>(T data) => Path.Combine(savePath, data?.GetType().GetFriendlyTypeName() ?? "");
        protected virtual string SaveNameByType(Type type) => Path.Combine(savePath, type.GetFriendlyTypeName() ?? "");

        public abstract object GetData(Type type);

        public bool TryGetData(Type type, out object data)
        {
            try
            {
                data = GetData(type);
                return true;
            }
            catch (Exception)
            {
                data = default!;
                return false;
            }
        }

        public abstract void SetData(Type type, object data);

        public bool TrySetData(Type type, object data)
        {
            try
            {
                SetData(type, data);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public abstract void AddConverter(JsonConverter item);

        public abstract void AddDerivedRelate(Type baseType, Type derivedType);

        public virtual void AddDerivedRelate<T, U>() where U : class, T where T : class
        {
            AddDerivedRelate(typeof(T), typeof(U));
        }

        public abstract T? DeSerialize<T>(string json) where T : class;
        public abstract string Serialize<T>(T data) where T : class;
    }
}
