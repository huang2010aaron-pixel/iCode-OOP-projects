using System;
using System.Collections.Generic;
using System.Text;

namespace NotetakingApp
{
    public class Note
    {
        private string _text;
        private DateTime _createdAt;
        private string _color;

        public static readonly string[] AvailableColors = new[]
        {
            "#d10000",
            "#ffda21",
            "#33dd00",
            "#1133cc",
            "#220066",
            "#330044"
        };

        public string Text
        {
            get => _text;
            set => _text = value ?? string.Empty;
        }

        public DateTime CreatedAt
        {
            get => _createdAt;
            private set => _createdAt = value;
        }

        public string CreatedAtFormatted => _createdAt.ToString("MM dd, yyyy h:mm tt");

        public string Color
        {
            get => _color;
            private set => _color = value;
        }

        public Note(string text, string color)
        {
            Text = text;
            CreatedAt = DateTime.Now;
            Color = color;
        }
    }
}
