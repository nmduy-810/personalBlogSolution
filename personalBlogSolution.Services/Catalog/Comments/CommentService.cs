using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personalBlogSolution.Data.EF;
using personalBlogSolution.Data.Entities;
using personalBlogSolution.Utilities.Constants;
using personalBlogSolution.ViewModels.Catalog.Comment;
using personalBlogSolution.ViewModels.Common.ApiResult;

namespace personalBlogSolution.Services.Catalog.Comments
{
    public class CommentService: ICommentService
    {
        private readonly PersonalBlogDbContext _context;

        public CommentService(PersonalBlogDbContext context)
        {
            _context = context;
        }
        
        public async Task<ApiResult<List<CommentVM>>> GetAll()
        {
            //1. Select join query
            var query = from cm in _context.Comments
                join p in _context.Posts on cm.PostId equals p.Id
                select new {cm, p};
            
            //2. Get data
            var data = await query.Select(item => new CommentVM()
            {
                Id = item.cm.Id,
                Title = item.cm.Title,
                Summary = item.cm.Summary,
                ParentId = item.cm.ParentId,
                DateCreated = item.cm.DateCreated,
                DateModified = item.cm.DateModified,
                PostTitle = item.p.Title,
                PostSummary = item.p.Summary,
                PostViewCount = item.p.ViewCount
            }).ToListAsync();
            
            //3. Return data
            return data == null ? new ApiErrorResult<List<CommentVM>>(SystemConstants.NotFoundDataMessage) : new ApiSuccessResult<List<CommentVM>>(data);
        }

        public async Task<ApiResult<CommentVM>> GetById(int commentId)
        {
            //1. Find id of comments
            var comment = await _context.Comments.FindAsync(commentId);

            if (comment == null)
            {
                return new ApiErrorResult<CommentVM>(SystemConstants.CanNotFindIdMessage + "comment table with Id: " + commentId);
            }

            //Find comment id in post
            var post = await _context.Posts.Where(x => x.Id == comment.PostId).FirstOrDefaultAsync();

            var data = new CommentVM()
            {
                Id = comment.Id,
                Title = comment.Title,
                Summary = comment.Summary,
                ParentId = comment.ParentId,
                DateCreated = comment.DateCreated,
                DateModified = comment.DateModified,
                PostTitle = post.Title,
                PostSummary = post.Summary,
                PostViewCount = post.ViewCount
            };

            //Return data
            return new ApiSuccessResult<CommentVM>(data);
        }

        public async Task<ApiResult<bool>> Create(CommentCreateRequest request)
        {
            var comment = new Comment()
            {
                Title = request.Title,
                Summary = request.Summary,
                ParentId = request.ParentId,
                DateCreated = request.DateCreated,
                DateModified = request.DateModified,
                PostId = request.PostId
            };

            var result = await _context.Comments.AddAsync(comment);
            
            await _context.SaveChangesAsync();
            return result == null ? new ApiErrorResult<bool>("Comment data can't create") : new ApiSuccessResult<bool>(SystemConstants.SuccessfulDataCreate);
        }

        public async Task<ApiResult<bool>> Update(CommentUpdateRequest request)
        {
            var comment = await _context.Comments.FindAsync(request.Id);

            if (comment == null)
            {
                return new ApiErrorResult<bool>(SystemConstants.CanNotFindIdMessage + "comment table with Id: " + request.Id);
            }

            comment.Title = request.Title;
            comment.Summary = request.Summary;

            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>(SystemConstants.SuccessfulDataUpdate);
        }

        public async Task<ApiResult<bool>> Delete(int commentId)
        {
            var comment = await _context.Comments.FindAsync(commentId);

            if (comment == null)
            {
                return new ApiErrorResult<bool>(SystemConstants.CanNotFindIdMessage + "comment table with Id: " + commentId);
            }
            
            _context.Comments.Remove(comment);
            
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>(SystemConstants.SuccessfulDataDelete);
        }
    }
}