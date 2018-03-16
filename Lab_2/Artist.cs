using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Artist
    {
        private string ArtistID;

        public string ArtistID1
        {
            get { return ArtistID; }
            set { ArtistID = value; }
        }
        private string Name;


        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        public Artist() { }
        public Artist(string ArtistID,string name)
        {
            this.ArtistID = ArtistID;
            this.Name = name;
        }
    }
}
