using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture 
{
    private readonly List<Word> words;
    public Reference Reference { get; }
    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        words = text.Split().Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        string displayLine = string.Join(" ", words.Select(w => w.IsHidden ? new string('_', w.Text.Length) : w.Text));
        Console.WriteLine($"{Reference.value}\n\n{displayLine}");
    }

    public void HideRandomWords(int numWords)
    {
        List<int> wordsToHide = Enumerable.Range(0, words.Count)
                                          .Where(i => !words[i].IsHidden)
                                          .OrderBy(_ => Guid.NewGuid())
                                          .Take(Math.Min(numWords, words.Count(w => !w.IsHidden)))
                                          .ToList();

        foreach (var index in wordsToHide)
        {
            words[index].IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden);
    }
}