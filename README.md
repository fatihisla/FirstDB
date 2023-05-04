# FirstDB

*Primo passo*:

1-Creare una cartella,nominarla e aprirla nel tuo visual studio code.

2-eseguire

    dotnet new console.

3-Andare su google e scaricare il file  chinook.db(il link file è giù).

4-Aggiungere il file nella cartella poi aggiungere se non si ha l'estensione SQLite.

![image](https://user-images.githubusercontent.com/116791165/235084027-85d0552d-eacd-4c47-aefd-7c0c4aab2f5d.png)

5-Mentre realizzi il codice noterai che questo comando darà errore : SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
  #Per risolvere l'errore dobbiamo includere la libreria sqlite-net-pcl tramite questo comando nel terminale: 
  //(è una L minuscola  non un 1)
    
    dotnet add package sqlite-net-pcl

6-Poi divertirsi nella creazione del programma.

--------------------------------------------------------------------------------------------------------
LINK:https://www.sqlitetutorial.net/sqlite-sample-database/  
Basterà scendere per trovare questo:

![image](https://user-images.githubusercontent.com/116791165/235083445-f47f8a37-b962-4ffd-b280-42026da64e0e.png)
-----------------------------------------------------------------------------------------------------------
 il codice C# necessario a visualizzare tutti gli artisti:
  
  //connessione a db
####
    
    SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
    
    var tblArtist = cn1.Query<Artist>("select * from artists ");
    
    Console.WriteLine($"in questa tabella ci sono {tblArtist.Count} record!");
####

#####
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
#####
In fine si utilizza il debug ed un punto di interruzzione poi si scrive nel terminale dotnet run e si controlla se funziona.

Immagine risultato:

![image](https://user-images.githubusercontent.com/116791165/236145925-08a4d4e3-8717-494c-8cd4-a4a2f15b9016.png)

l'obbiettivo è sapere quanti record ci sono nella tabella  sottostante.
Immagine tabella artists:

![image](https://user-images.githubusercontent.com/116791165/235088291-31d378fd-01f6-46e7-82a4-e8979eb69854.png)

-Fonti:

  _Informazioni prese da una lezione di  M. Conti e M. Sartini
  
  _Dal sito di Microsoft.
























