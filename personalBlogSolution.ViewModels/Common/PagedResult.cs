using System.Collections.Generic;

namespace personalBlogSolution.ViewModels.Common
{
    public class PagedResult<T>: PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}