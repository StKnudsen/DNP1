namespace S05_Ex02_AuthWithTailwind.Models
{
    public class Article
    {
        public static string Title;
        public static string[] Content;

        public Article(string title, string[] content)
        {
            Title = title;
            Content = content;
        }

        public string Title1
        {
            get => Title;
            set => Title = value;
        }

        public string[] Content1
        {
            get => Content;
            set => Content = value;
        }
    }
}