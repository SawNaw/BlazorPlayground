using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPlayground.Data
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime DateAdded { get; set; }
        public IReadOnlyList<IBrowserFile> AssociatedFiles {get; set;}

        public TodoItem(string title)
        {
            this.Title = title;
            this.IsDone = false;
            this.DateAdded = DateTime.Now;
        }
    }
}
