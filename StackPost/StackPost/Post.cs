namespace StackPost
{
    public class Post
    {

        public string Title { get; }
        public string Content { get; }
        public DateTime Created { get; }
        private int _upVote;
        private int _downVote;

        public Post(string title, string content)
        {
            if(string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException("Title cant be empty");
            }
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentNullException("Content cant be null");
            }

            Title = title;
            Content = content;
            Created = DateTime.Now;
            _downVote = 0;
            _upVote = 0;
            DisplayPost();
        }

        public void Vote(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
               
                    throw new InvalidOperationException("No such option available");            
            }

            if (input == "u")
            {
                _upVote++;
                DisplayPost();
            }
            else if (input == "d")
            {
                _downVote++;
                DisplayPost();

            }
            else
            {
                throw new InvalidOperationException("No such operation");
            }
           
        }

        public void DisplayPost()
        {
            Console.Clear();
            Console.WriteLine($"Title : {Title} \t\t\t Created at {Created} \n\n {Content} \n\n\t Upvote : {_upVote} Downvote : {_downVote} ");
        }

    }
}