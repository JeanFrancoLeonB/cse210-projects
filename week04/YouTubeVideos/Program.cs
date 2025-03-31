using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

    List<Video> _video = new List<Video>();
    
    Video Video1 = new Video("Globos en el Cielo", "Pedro Suarez V", 120);
    Comment Comentario1 = new Comment("Jersson", "Muy buena Canción");
    Comment Comentario2 = new Comment("Franco", "Buena Canción");
    Comment Comentario3 = new Comment("Carlos", "Regular Canción");
    Comment Comentario4 = new Comment("Juan", "Mala Canción");
        
    Video1.AddComments(Comentario1);
    Video1.AddComments(Comentario2);
    Video1.AddComments(Comentario3);
    Video1.AddComments(Comentario4);

    Video Video2 = new Video("Perfect", "Simple Plan", 150);
    Comment Comentario5 = new Comment("Juaquin", "Muy buena Canción");
    Comment Comentario6 = new Comment("Cristian", "Buena Canción");
    Comment Comentario7 = new Comment("Sofia", "Regular Canción");
    Comment Comentario8 = new Comment("Magdalena", "Mala Canción");
        
    Video2.AddComments(Comentario5);
    Video2.AddComments(Comentario6);
    Video2.AddComments(Comentario7);
    Video2.AddComments(Comentario8);


    Video Video3 = new Video("Stronger", "Kanye West", 180);
    Comment Comentario9 = new Comment("Elvira", "Muy buena Canción");
    Comment Comentario10 = new Comment("Inocente", "Buena Canción");
    Comment Comentario11 = new Comment("Lenny", "Regular Canción");
    Comment Comentario12 = new Comment("Jose", "Mala Canción");
        
    Video3.AddComments(Comentario9);
    Video3.AddComments(Comentario10);
    Video3.AddComments(Comentario11);
    Video3.AddComments(Comentario12);

    _video.Add(Video1);
    _video.Add(Video2);
    _video.Add(Video3);

    foreach (Video listaVideo in _video)
            {
                listaVideo.DisplayVideo();
            }

    }
}