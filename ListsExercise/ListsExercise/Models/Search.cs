using System;

namespace ListsExercise.Models
{
    public class Search
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public string Period 
        { 
            get 
            {
                return string.Format("{0} - {1}",
                    CheckIn.ToString("MMM dd, yyyy"),
                    CheckOut.ToString("MMM dd, yyyy"));
            }
        }
    }
}
