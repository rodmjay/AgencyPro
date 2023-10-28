namespace AgencyPro.Comments.Models
{
    public class CommentInput
    {
        public string Body { get; set; }
        public virtual bool Internal { get; set; }
    }
}