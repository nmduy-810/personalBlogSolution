﻿using System;
using System.Collections.Generic;
using personalBlogSolution.Data.Enums;

namespace personalBlogSolution.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public int SortOrder { get; set; }

        public bool IsShowOnHome { get; set; }

        public int ParentId { get; set; }

        public Status Status { get; set; }
    
        //relationship: n-n
        public List<PostInCategory> PostInCategories { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
