using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint04
{
    public enum ColourEnum { Red, Green, Blue }

    public interface IColoured
    {        
        ColourEnum Colour { get => ColourEnum.Red; }
    }

    public interface IDocument
    {
        static string defaultText = "Lorem ipsum";
        int Pages { get; set; }
        string Name { get; set; }
        void AddPages(int number) => Pages += number;
        void Rename(string newName) => Name = newName;
    }

    public class ColouredDocument : IColoured, IDocument
    {
        public ColouredDocument(ColourEnum colour)
        {
            Colour = colour;
        }

        public ColouredDocument() { }
        public int Pages { get; set; }
        public string Name { get; set; }
        public ColourEnum Colour { get; set; }
    }

    public class Example
    {
        public static void Do()
        {
            IDocument colouredDocument = new ColouredDocument() { Name = "Document1" };
            Console.WriteLine(colouredDocument.Name);
            colouredDocument.Rename("Document2");
            Console.WriteLine(colouredDocument.Name);
        }
    }
}
