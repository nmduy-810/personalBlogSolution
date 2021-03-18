using System;

namespace personalBlogSolution.Utilities.Exceptions
{
    public class PersonalBlogSolutionException: Exception
    {
        public PersonalBlogSolutionException()
        {
        }

        public PersonalBlogSolutionException(string message)
            : base(message)
        {
        }

        public PersonalBlogSolutionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}