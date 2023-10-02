using System;
using System.Collections.Generic;
using System.Text;

namespace ListsExercise.Models
{
    public class SearchGroup: Search
    {
        public string Title { get; set; }
        public SearchGroup(string title)
        {
            Title = title;
        }
    }
}
