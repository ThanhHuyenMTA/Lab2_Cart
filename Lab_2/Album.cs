using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
  public  class Album
    {
        private string AlbumID;

        public string AlbumID1
        {
            get { return AlbumID; }
            set { AlbumID = value; }
        }
        private string Genreid;

        public string Genreid1
        {
            get { return Genreid; }
            set { Genreid = value; }
        }
        private string ArtistID;

        public string ArtistID1
        {
            get { return ArtistID; }
            set { ArtistID = value; }
        }
        private string Title;

        public string Title1
        {
            get { return Title; }
            set { Title = value; }
        }
        private double Price;

        public double Price1
        {
            get { return Price; }
            set { Price = value; }
        }
        private string AlbumUrl;

        public string AlbumUrl1
        {
            get { return AlbumUrl; }
            set { AlbumUrl = value; }
        }
        public Album() { }
        public Album(string AlbumID, string Genreid, string Title, double Price)
        {
            this.AlbumID1 = AlbumID;
            this.Genreid = Genreid;
            this.Title = Title;
            this.Price = Price;
        }
        public Album(string AlbumID, string Genreid, string ArtistID, string Title, double Price, string AlbumUrl)
        {
            this.AlbumID1 = AlbumID;
            this.Genreid = Genreid;
            this.ArtistID = ArtistID;
            this.Title = Title;
            this.Price = Price;
            this.AlbumUrl = AlbumUrl;
        }
      public string OutputAlbum()
        {
            string row1 = "List of all albums\n";
            row1 += "ID\tGenre\tTitle							        Price\n";
            row1 +=""+ AlbumID+"\t"+Genreid+"\t"+Title+"\t\t\t"+Price+"\n";        
            return row1;
        }
    }
}
