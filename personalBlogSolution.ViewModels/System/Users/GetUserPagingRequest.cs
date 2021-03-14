using personalBlogSolution.ViewModels.Common;

namespace personalBlogSolution.ViewModels.System.Users
{
    public class GetUserPagingRequest: PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}