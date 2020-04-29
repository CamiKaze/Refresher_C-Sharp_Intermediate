using System;

namespace StackOverflowPost
{
    public class StackOverflowPost
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }

        public void PostTitle(string title)
        {
            Title = title;
        }
        public void PostDescription(string description)
        {
            Description = description;
        }

        public void PostCreation(DateTime createdDate)
        {
            CreationDate = createdDate;
        }
        public void PostLike(int like)
        {
            Like += like;
        }

        public void PostDislike(int dislike)
        {
            Dislike += dislike;
        }
    }
}
