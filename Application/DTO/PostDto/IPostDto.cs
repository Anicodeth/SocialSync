using Domain.Entities;

namespace Application.DTO.Post;

public interface IPostDto
{
    public string Content{ get; set; }
    public List<string> Tags{ get; set; }
    public int UserId  {get;set;}
}