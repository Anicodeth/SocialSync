﻿
namespace Domain.Entities
{
    public class Like
    {
        //The user that liked the post
        public required int UserId { get; set; }
        public required int PostId { get; set; }

        //Navigation Property
        public virtual User? User{ get; set; }
        public virtual Post? Post{ get; set; }
    }
}
