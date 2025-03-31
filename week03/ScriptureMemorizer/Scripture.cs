using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        /*Los corchetes significan que es un array, diferencia entre el array y la lista (tipos y clases)*/
        string[] texto = text.Split(' ');

        foreach (string x in texto)
        {
            Word p1 = new Word(x);
            _words.Add(p1);
        }
    }
    public void HideRandomWords()
    {
        Random aleatorio = new Random();
        List<Word> _palabrasvisibles = new List<Word>();
        foreach (Word y in _words)
        {
            if (!y.IsHiden())
            {
                _palabrasvisibles.Add(y);
            }
        }

        if (_palabrasvisibles.Count == 0)
        {

            return;
        }


        for (int i = 0; i < _palabrasvisibles.Count; i++)
        {
            int al = aleatorio.Next(_palabrasvisibles.Count());
            _palabrasvisibles[al].Hide();
            /*RmoveAt remueve posicion especifica, removeAll toda la lista*/
            _palabrasvisibles.RemoveAt(al);
        }

    }
    public string GetDisplayText()
    {
        /*\n es el enter*/
        string despliegatexto = _reference.GetDisplayText() + "\n ";

        foreach (Word z in _words)
        {
            despliegatexto += z.GetDisplayText() + " ";
        }
        return despliegatexto;
    }
    public bool IsCompletelyHidden()
    {
        /*ishiden es falso devolver la funcion en falso, quiere decir que la palabra es */

        foreach (Word z in _words)
        {
            if (!z.IsHiden())
            {
                return false;
            }
        }
        return true;
    }
}