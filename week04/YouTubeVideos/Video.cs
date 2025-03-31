public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private static List<Comment> _comment;
    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _length = lenght;
        _comment = new List<Comment>();

    }
    public void AddComments(Comment comment)
    {

        _comment.Add(comment);
    }
    public int NumberComments()
    {
        return _comment.Count();
    }
    public void DisplayVideo()
    {
        Console.WriteLine($" {_title}, Autor: {_author}, Duración :{_length} Segundos . \n");

        foreach (Comment comment in _comment)
        {
            string comentario = $"{comment.DisplayComment()}";
            Console.WriteLine($"{comentario} \n");
        }
        Console.WriteLine("____________________________________");
    }
}
