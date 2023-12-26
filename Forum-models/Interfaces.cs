using Forum_models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum_models
{

    public interface IForum
    {
        Models.Forum GetById(int id);
        IEnumerable<Models.Forum> GetAll();
        Task Create(Models.Forum forum);
        Task Delete(int id);
        Task UpdateForumTitle(int id, string title);
        Task UpdateForumDescription(int id, string description);
        Post GetLatestPost(int forumId);
        IEnumerable<User> GetActiveUsers(int forumId);
        bool HasRecentPost(int id);
        Task Add(Models.Forum forum);
        Task SetForumImage(int id, Uri uri);
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetFilteredPosts(int forumId, string modelSearchQuery);
    }
    public interface IPost
    {
        Task Add(Post post);
        Task Archive(int id);
        Task Delete(int id);
        Task EditPostContent(int id, string content);

        Task AddReply(PostReply reply);

        int GetReplyCount(int id);

        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetPostsByUserId(int id);
        IEnumerable<Post> GetPostsByForumId(int id);
        IEnumerable<Post> GetPostsBetween(DateTime start, DateTime end);
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<User> GetAllUsers(IEnumerable<Post> posts);
        IEnumerable<Post> GetLatestPosts(int forumId);
        string GetForumImageUrl(int id);
    }
    public interface IPostReply
    {
        PostReply GetById(int id);
        Task Edit(int id, string message);
        Task Delete(int id);
    }
    public interface IUser
    {
        User GetById(string id);
        IEnumerable<User> GetAll();

        Task IncrementRating(string id);
        Task Add(User user);
        Task Deactivate(User user);
        Task SetProfileImage(string id, Uri uri);
    }
}
