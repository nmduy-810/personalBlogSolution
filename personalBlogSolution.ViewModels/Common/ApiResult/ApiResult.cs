namespace personalBlogSolution.ViewModels.Common.ApiResult
{
    public class ApiResult<T>
    {
        //Check data is success
        public bool IsSuccess { get; set; }

        //Message use export error or success message
        public string Message { get; set; }

        //Return data
        public T ResultDataObject { get; set; }
    }
}