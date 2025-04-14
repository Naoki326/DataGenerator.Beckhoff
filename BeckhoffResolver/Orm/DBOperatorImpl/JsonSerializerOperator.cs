using ORM.Framework;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.Unicode;

namespace ORM.DBOperatorImpl
{

    internal class PolymorphicTypeResolver : DefaultJsonTypeInfoResolver
    {

        public Dictionary<Type, HashSet<Type>> TypeMappings { get; } = [];

        public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
        {
            JsonTypeInfo jsonTypeInfo = base.GetTypeInfo(type, options);

            foreach (var baseType in TypeMappings.Keys)
            {
                if (jsonTypeInfo.Type == baseType
                    && jsonTypeInfo.Kind != JsonTypeInfoKind.None)
                {
                    jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
                    {
                        TypeDiscriminatorPropertyName = baseType.GetFriendlyTypeName(),
                        DerivedTypes = { },
                    };
                    foreach (var derivedType in TypeMappings[baseType])
                    {
                        jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(new JsonDerivedType(derivedType, derivedType.GetFriendlyTypeName()));
                    }
                }
            }
            return jsonTypeInfo;
        }
    }

    public class JsonSerializerOperator : AbstractDBOperator, IDBOperator
    {
        PolymorphicTypeResolver resolver = new();
        public JsonSerializerOperator(string savePathArg) : base(savePathArg)
        {
            options.TypeInfoResolver = resolver;
        }

        public override void AddDerivedRelate(Type baseType, Type derivedType)
        {
            if (!resolver.TypeMappings.TryGetValue(baseType, out HashSet<Type>? value))
            {
                resolver.TypeMappings[baseType] = [derivedType];
            }
            else
            {
                value.Add(derivedType);
            }
        }

        protected override string SaveName<T>()
        {
            return base.SaveName<T>() + ".json";
        }

        protected override string SaveName<T>(T data)
        {
            return base.SaveName(data) + ".json";
        }

        protected override string SaveNameByType(Type type)
        {
            return base.SaveNameByType(type) + ".json";
        }

        public override void AddConverter(JsonConverter converter)
        {
            options.Converters.Add(converter);
        }

        private readonly JsonSerializerOptions options = new()
        {
            // 整齐打印
            WriteIndented = true,
            // 设置Json字符串支持的编码，默认情况下，序列化程序会转义所有非 ASCII 字符。 即，会将它们替换为 \uxxxx，其中 xxxx 为字符的 Unicode
            // 代码。 可以通过设置Encoder来让生成的josn字符串不转义指定的字符集而进行序列化 下面指定了基础拉丁字母和中日韩统一表意文字的基础Unicode 块
            // (U+4E00-U+9FCC)。 基本涵盖了除使用西里尔字母以外所有西方国家的文字和亚洲中日韩越的文字
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.CjkUnifiedIdeographs),
            // 反序列化不区分大小写
            PropertyNameCaseInsensitive = false,
            // 驼峰命名
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,

            //// 对字典的键进行驼峰命名
            //DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
            // 序列化的时候忽略null值属性
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            // 忽略只读属性，因为只读属性只能序列化而不能反序列化，所以在以json为储存数据的介质的时候，序列化只读属性意义不大
            IgnoreReadOnlyFields = true,
            // 不允许结尾有逗号的不标准json
            AllowTrailingCommas = false,
            // 不允许有注释的不标准json
            ReadCommentHandling = JsonCommentHandling.Disallow,
            // 允许在反序列化的时候原本应为数字的字符串（带引号的数字）转为数字
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
            // 处理循环引用类型，比如Book类里面有一个属性也是Book类
            ReferenceHandler = ReferenceHandler.Preserve
        };

        public override string Serialize<T>(T data) where T : class
        {
            return JsonSerializer.Serialize(data, options);
        }

        public override T? DeSerialize<T>(string json) where T : class
        {
            return JsonSerializer.Deserialize<T>(json, options);
        }

        public override void SetData<T>(T data) where T : class
        {
            string path = SaveName(data);
            using FileStream sw = new(path, FileMode.Create, FileAccess.Write);
            JsonSerializer.Serialize(sw, data, options);
        }

        public override void SetData(Type type, object data)
        {
            string path = SaveName(data);
            using FileStream sw = new(path, FileMode.Create, FileAccess.Write);
            JsonSerializer.Serialize(sw, data, type, options);
        }

        public override T GetData<T>() where T : class
        {
            string path = SaveName<T>();
            using FileStream fs = new(path, FileMode.Open, FileAccess.Read);
            if (JsonSerializer.Deserialize<T>(fs, options) is not T serializedDatas)
            {
                throw new InvalidOperationException($"Deserialize {typeof(T).GetFriendlyTypeName()} failed!");
            }
            return serializedDatas;
        }

        public override object GetData(Type type)
        {
            string path = SaveNameByType(type);
            using FileStream fs = new(path, FileMode.Open, FileAccess.Read);
            if (JsonSerializer.Deserialize(fs, type, options) is not object serializedDatas)
            {
                throw new InvalidOperationException($"Deserialize {type.GetFriendlyTypeName()} failed!");
            }
            return serializedDatas;
        }
    }
}
