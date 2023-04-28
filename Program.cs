// See https://aka.ms/new-console-template for more information
using SQLite;



Console.WriteLine("Hello, DBWorld!");

    //connessione a db
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtist = cn1.Query<Artist>("select * from artists ");
Console.WriteLine($"in questa tabella ci sono {tblArtist.Count} record!");


//------------------------
public class Artist
{
    public int ArtistId { get; set; }
    public string Name { get; set; }

}
