using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Assignment1.Data
{
    public class NoteEntry : ContentPage
    {
        public string minutesTitle { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public string minutesId { get; set; }

        public NoteEntry()
        {
            CreatedDate = DateTime.Now;
            minutesId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{minutesTitle} {CreatedDate}";
        }
    }
}