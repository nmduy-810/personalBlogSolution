namespace personalBlogSolution.ViewModels.Common.ApiResult
{
    public class ApiSuccessResult<T>: ApiResult<T>
    {
        //Constructor always return true when success
        public ApiSuccessResult()
        {
            IsSuccess = true;
        }

        public ApiSuccessResult(T resultObjectData)
        {
            IsSuccess = true;
            ResultObjectData = resultObjectData;
        }
    }
}