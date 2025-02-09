﻿namespace Lab_2.Composite.SimpleElements
{
    class PunctuationMark : IComponent
    {
        public char Contents { get; private set; }

        public PunctuationMark() { Contents = default; }

        public string ChildCount => $"0";

        public IComponent Parent { get; set; }

        public bool IsDefault() { return Contents == default ? true : false; }

        public void Parse(string contents)
        {
            if (contents.Length > 1) throw new System.ArgumentOutOfRangeException();
            if (char.IsPunctuation(contents[0])) this.Contents = contents[0];
        }

        public void Parse(char contents)
        {
            if (char.IsPunctuation(contents)) this.Contents = contents;
        }

        public override string ToString()
        {
            string tmp = $"   {GetType().Name}\n    << {Contents} >> \n";

            return tmp;
        }
    }
}
