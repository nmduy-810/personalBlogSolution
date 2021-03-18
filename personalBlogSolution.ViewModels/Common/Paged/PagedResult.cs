using System.Collections.Generic;

namespace personalBlogSolution.ViewModels.Common.Paged
{
    public class PagedResult<T>: PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}