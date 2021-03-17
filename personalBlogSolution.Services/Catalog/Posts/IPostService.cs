using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using personalBlogSolution.ViewModels.Catalog.Post;

namespace personalBlogSolution.Services.Catalog.Posts
{
    public interface IPostService
    {
        //Lấy tất cả các danh sách bài viết
        Task<List<PostVM>> GetAll();

        //Lấy bài viết theo id của bài viết
        Task<PostVM> GetById(int postId);
        
        //Tạo bài viết mới
        Task<int> Create(PostCreateRequest request);

        //Cập nhật bài viết
        Task<int> Update(PostUpdateRequest request);

        //Xoá bài viết
        Task<int> Delete(int id);
        
        //Helper Methods
        Task<string> SaveFile(IFormFile file);
    }
}