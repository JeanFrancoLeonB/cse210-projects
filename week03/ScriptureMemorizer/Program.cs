using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    Reference referencia = new Reference("Daniel", 9, 24);

    string versiculo = "Setenta semanas han sido decretadas sobre tu pueblo y sobre tu santa ciudad, para poner fin a la transgresión, para terminar con el pecado, para expiar la iniquidad, para traer justicia eterna, para sellar la visión y la profecía, y para ungir el lugar santísimo.";
    Scripture escritura = new Scripture(referencia, versiculo);


    while (!escritura.IsCompletelyHidden()) 
    {
      Console.Clear();
      Console.WriteLine(escritura.GetDisplayText());

      Console.WriteLine("Press enter to Continue or 'quit' to finish");

      string entrada = Console.ReadLine();

      if (entrada.ToLower() == "quit")  break;

      escritura.HideRandomWords();
    }

    Console.Clear();
    Console.WriteLine("Gracias por su participación");


    /*
    private static List<Word> _words = new List<Word>
    {
        
        "",
        "Daniel 7:13 Seguí mirando en las visiones nocturnas, y he aquí, con las nubes del cielo venía uno como un Hijo de Hombre, que se dirigió al Anciano de Días y fue presentado ante El.",
        "Juan 3:16 Porque de tal manera amó Dios al mundo, que dio a su Hijo unigénito, para que todo aquel que cree en El, no se pierda, mas tenga vida eterna.",
        "Juan 10:10 El ladrón sólo viene para robar y matar y destruir; yo he venido para que tengan vida, y para que la tengan en abundancia.",
        "Pedro 1:1 Pedro, apóstol de Jesucristo: A los expatriados, de la dispersión en el Ponto, Galacia, Capadocia, Asia y Bitinia, elegidos",
        "Pedro 5:13 La que está en Babilonia, elegida juntamente con vosotros, os saluda, y también mi hijo Marcos."
    };
    */

  }
}