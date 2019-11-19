using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Movie
    {
        private string category;
        private string title;
        
        public Movie(string title, string category)
        {
            Category = category;
            Title = title;  
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
