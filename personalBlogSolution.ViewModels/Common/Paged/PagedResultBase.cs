using System;

namespace personalBlogSolution.ViewModels.Common.Paged
{
    public class PagedResultBase
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalRecords { get; set; }

        public int TotalCount
        {
            get
            {
                var pageCount = (double) TotalRecords / PageSize;
                return (int) Math.Ceiling(pageCount);
            }
        }
    }
}