using Domain.Models;
public class PostService
{
    public List<Post> posts;
    public List<Post> GetPosts ()
    {
return posts;
    }
    public void AddPosts (Post post )
    {
        posts.Add(post);
    }
     public void UpdatePosts (Post post)
    {
        var find  = posts.FirstOrDefault(x=>x.id == post.id);
        find.Title =post.Title;
        find.id =post.id;
        find.VoteAmount =post.VoteAmount;
        
    }
    public void Delete (int id)
    {
       var find  = posts.FirstOrDefault(x=>x.id == id); 
       posts.Remove(find);
    }
}