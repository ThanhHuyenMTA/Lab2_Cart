using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
   public class Genre
    {
        private string GenreID;

        public string GenreID1
        {
            get { return GenreID; }
            set { GenreID = value; }
        }
        private string Name;

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        //Mô tả
        private string Description;

        public string Description1
        {
            get { return Description; }
            set { Description = value; }
        }
        public Genre() { }
        public Genre(string GenreID, string name, string description)
        {
            this.GenreID = GenreID;
            this.Name = name;
            this.Description = description;
        }
    }
}
