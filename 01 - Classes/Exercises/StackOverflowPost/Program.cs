using System;

namespace StackOverflowPost
{
    /* Design a StackOverﬂow Post
       Design a class called Post. This class models a StackOverﬂow post.
       It should have properties for title, description and the date/time
       it was created. We should be able to up-vote or down-vote a post. We
       should also be able to see the current vote value. In the main
       method, create a post, up-vote and down-vote it a few times and then
       display the current vote value.

       In this exercise, you will learn that a StackOverﬂow post should
       provide methods for up-voting and down voting. You should not give
       the ability to set the Vote property from the outside, because
       otherwise, you may accidentally change the votes of a class to 0 or
       to a random number. And this is how we create bugs in our programs.
       The class should always protect its state and hide its implementation
       detail.

       Educational tip: The aim of this exercise is to help you understand
       that classes should encapsulate data AND behaviour around that data.
       Many developers (even those with years of experience) tend to create
       classes that are purely data containers, and other classes that are
       purely behaviour (methods) providers. This is not object-oriented
       programming. This is procedural programming. Such programs are very
       fragile. Making a change breaks many parts of the code.
    */
    class Program
    {
        static void Main(string[] args)
        {
            var post = new StackOverflowPost();
            Title(post);
            Description(post);
            CreationDate(post);

            Like(post);
            Console.WriteLine("Title: {0}\n"
            + "Description: {1}\n"
            + "Created on {2}\n"
            + "{3} people liked your post\n"
            + "{4} disliked your post\n",
             post.Title, post.Description, post.CreationDate, post.Like, post.Dislike);
        }

        private static void Title(StackOverflowPost post)
        {
            post.PostTitle("Welcome to my C# Course");
        }

        private static void Description(StackOverflowPost post)
        {
            post.PostDescription("This is an intermediate level course");
        }

        private static void CreationDate(StackOverflowPost post)
        {
            post.PostCreation(DateTime.Now);
        }

        private static void Like(StackOverflowPost post)
        {
            post.PostLike(1);
            post.PostLike(1);
            post.PostLike(1);
            post.PostDislike(1);
            post.PostDislike(1);
        }
    }
}
