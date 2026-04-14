using System;
using System.Collections.Generic;

class User
{
    public string Username { get; set; }
    public string FullName { get; set; }
    public List<User> Friends { get; set; }
    public List<Post> Posts { get; set; }

    public User(string username, string fullName)
    {
        Username = username;
        FullName = fullName;
        Friends = new List<User>();
        Posts = new List<Post>();
    }

    public void AddFriend(User friend)
    {
        if (friend == this)
        {
            Console.WriteLine("You cannot add yourself");
            return;
        }
        if (!Friends.Contains(friend))
        {
            Friends.Add(friend);
            Console.WriteLine($"{friend.FullName} added as friend.");
        }
        else
        {
            Console.WriteLine($"{friend.FullName} is already your friend.");
        }
    }

    public void RemoveFriend(User friend)
    {
        if (Friends.Contains(friend))
        {
            Friends.Remove(friend);
            Console.WriteLine($"{friend.FullName} removed from friends");
        }
        else
        {
            Console.WriteLine($"{friend.FullName} is not your friend");
        }
    }

    public void ShowFeed()
    {
        Console.WriteLine($"\n{FullName}'s Feed:");
        List<Post> feed = new List<Post>();
        foreach (var friend in Friends)
        {
            feed.AddRange(friend.Posts);
        }
        feed.Reverse();

        if (feed.Count == 0)
        {
            Console.WriteLine("No posts to show.");
            return;
        }

        foreach (var post in feed)
        {
            Console.WriteLine($"{post.Author.FullName} posted: \"{post.Content}\" (Likes: {post.Likes.Count})");
            foreach (var comment in post.Comments)
            {
                Console.WriteLine($"  {comment.Author.FullName} commented: \"{comment.Content}\" (Likes: {comment.Likes.Count})");
            }
        }
    }
}

class Post
{
    public User Author { get; set; }
    public string Content { get; set; }
    public List<Comment> Comments { get; set; }
    public List<User> Likes { get; set; }

    public Post(User author, string content)
    {
        Author = author;
        Content = content;
        Comments = new List<Comment>();
        Likes = new List<User>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void AddLike(User user)
    {
        if (!Likes.Contains(user))
            Likes.Add(user);
    }
}

class Comment
{
    public User Author { get; set; }
    public string Content { get; set; }
    public List<User> Likes { get; set; }

    public Comment(User author, string content)
    {
        Author = author;
        Content = content;
        Likes = new List<User>();
    }

    public void AddLike(User user)
    {
        if (!Likes.Contains(user))
            Likes.Add(user);
    }
}

class Program
{
    static void Main()
    {        
        User alice = new User("alice", "Alice Johnson");
        User bob = new User("bob", "Bob Smith");
        User carol = new User("carol", "Carol White");
        alice.AddFriend(bob);
        bob.AddFriend(carol);

        Post post1 = new Post(alice, "Hello world!");
        alice.Posts.Add(post1);

        Post post2 = new Post(bob, "C# is fun!");
        bob.Posts.Add(post2);
        Comment comment1 = new Comment(bob, "Nice post!");
        post1.AddComment(comment1);

        Comment comment2 = new Comment(carol, "I agree!");
        post2.AddComment(comment2);
        post1.AddLike(bob);
        comment1.AddLike(carol);
        alice.ShowFeed();
        bob.ShowFeed();
        carol.ShowFeed();
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}