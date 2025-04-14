namespace PlcCore.Data
{
    public class BaseResult<T>
    {
        public bool IsSuccess { get; }

        public T Value { get; }

        public BaseResult()
        {
            IsSuccess = false;
            Value = default;
        }

        public BaseResult(T value)
        {
            IsSuccess = true;
            Value = value;
        }

        public static BaseResult<T> Failure()
        {
            return new BaseResult<T>();
        }

        public static BaseResult<T> Success(T data)
        {
            return new BaseResult<T>(data);
        }

    }

    public class Result<T> : BaseResult<T> where T : struct
    {
        public Result() : base()
        {
        }

        public Result(T value) : base(value)
        {
        }

        public static new Result<T> Failure()
        {
            return new Result<T>();
        }

        public static new Result<T> Success(T data)
        {
            return new Result<T>(data);
        }

    }

    public class ResultArray<T> : BaseResult<T[]> where T : struct
    {
        public ResultArray() : base()
        {
        }

        public ResultArray(T[] value) : base(value)
        {
        }

        public static new ResultArray<T> Failure()
        {
            return new ResultArray<T>();
        }

        public static new ResultArray<T> Success(T[] data)
        {
            return new ResultArray<T>(data);
        }
    }
}
