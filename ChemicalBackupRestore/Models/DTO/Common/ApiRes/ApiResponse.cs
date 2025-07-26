public class ApiResponse<T>
{
    public int Code { get; set; } 
    public string Message { get; set; } = "Success";
    public bool IsSuccess { get; set; } = true;
    public T? Data { get; set; }

    public static ApiResponse<T> Success(T data, string message = "Success", int code = 200)
    {
        return new ApiResponse<T>
        {
            Code = code,
            Message = message,
            IsSuccess = true,
            Data = data
        };
    }

    public static ApiResponse<T> Fail(string message, int code = 500)
    {
        
        return new ApiResponse<T>
        {
            Code = code,
            Message = message,
            IsSuccess = false,
            Data = default
        };
    }
}