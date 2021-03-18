namespace personalBlogSolution.ViewModels.Common.ApiResult
{
    public class ApiSuccessResult<T>: ApiResult<T>
    {
        //Constructor always return true when success
        public ApiSuccessResult()
        {
            IsSuccess = true;
        }

        public ApiSuccessResult(string message)
        {
            IsSuccess = true;
            Message = message;
        }

        public ApiSuccessResult(T resultDataObject)
        {
            IsSuccess = true;
            ResultDataObject = resultDataObject;
        }
    }
}