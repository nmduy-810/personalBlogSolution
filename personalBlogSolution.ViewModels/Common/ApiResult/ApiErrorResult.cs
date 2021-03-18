namespace personalBlogSolution.ViewModels.Common.ApiResult
{
    public class ApiErrorResult<T>: ApiResult<T>
    {
        public ApiErrorResult(string errorMessage)
        {
            IsSuccess = false;
            Message = errorMessage;
        }
    }
}