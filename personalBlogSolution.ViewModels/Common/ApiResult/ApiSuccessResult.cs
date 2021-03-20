namespace personalBlogSolution.ViewModels.Common.ApiResult
{
    public class ApiSuccessResult<T>: ApiResult<T>
    {
        //Constructor always return true when success
        public ApiSuccessResult(T resultDataObject)
        {
            IsSuccess = true;
            ResultDataObject = resultDataObject;
        }

        public ApiSuccessResult()
        {
            IsSuccess = true;
        }
    }
}