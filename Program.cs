using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A hasítótábla egy olyan adatszerkezet, amelyben a kulcs-érték párokat egy tömbben tároljuk.
 * A hatékony keresés, beszúrás és törlés érdekében használ egy hash függvényt, ami egy kulcsból számít egy hash kódot.
 * 
 * Hasító függvény:  Az adatok tárolásának és keresésének hatékonyságát nagyban befolyásolja a hash függvény minősége. 
 * Egy jó hash függvény egyenletesen osztja el a kulcsokat a hash táblában.
 * 
 * Ütközések kezelése: Amikor két különböző kulcs ugyanazt a hash kódot eredményezi, ütközésről beszélünk. 
 * Ezt általában láncolt listákkal vagy nyílt címzéssel kezelik.
 * 
 */

namespace HashTableFromNeptunCode
{
    public class HashTable
    {
        private const int MERET = 17;  // A hasítótábla mérete -> Prím szám
        public int Meret => MERET;  // A hasítótábla mérete (csak olvasható property)
        public LinkedList<KeyValuePair<char, string>>[] elemek;   // A hasítótábla elemei

        // Konstruktor
        public HashTable()
        {
            elemek = new LinkedList<KeyValuePair<char, string>>[MERET];
            for (int i = 0; i < MERET; ++i)
            {
                elemek[i] = new LinkedList<KeyValuePair<char, string>>();
            }
        }

        public int TombPozicioLekeres(char kulcs)
        {
            return kulcs % MERET;  // Hash kód kiszámítása (a karakter ASCII kódja modulóval)
        }

        public void Hozzaad(char kulcs)
        {
            int pozicio = TombPozicioLekeres(kulcs);  // Pozíció kiszámítása
            string ertek = $"ASCII: {(int)kulcs}";  // Érték létrehozása a karakter ASCII kódjából
            KeyValuePair<char, string> elem = new KeyValuePair<char, string>(kulcs, ertek);  // Új kulcs-érték pár létrehozása
            elemek[pozicio].AddLast(elem);  // Hozzáadás a megfelelő pozícióhoz
        }

        public IEnumerable<KeyValuePair<char, string>> Lekeres(char key)
        {
            int pozicio = TombPozicioLekeres(key);  // Pozíció kiszámítása
            return elemek[pozicio];  // Visszaadás
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            HashTable hasitoTabla = new HashTable();
            string neptunKod = "MRWFFP";

            foreach (char karakter in neptunKod)
            {
                hasitoTabla.Hozzaad(karakter);
            }

            foreach (char karakter in neptunKod)
            {
                int hasitoKod = hasitoTabla.TombPozicioLekeres(karakter);  // Hash kód kiszámítása
                Console.WriteLine($"{karakter} karakter hash kódja: {hasitoKod}");  // Kiíratás
                foreach (var h in hasitoTabla.Lekeres(karakter))  // Érték lekérdezése
                {
                    if (h.Key == karakter)  // Ha a kulcs megegyezik a keresett karakterrel
                        Console.WriteLine($"Érték a(z) '{karakter}' karakterből: {h.Value}");  // Érték kiíratása
                }
            }

            // Tömb aktuális értékeinek kiíratása
            Console.WriteLine("\nA hasítótábla tartalma:");
            for (int i = 0; i < hasitoTabla.Meret; ++i)
            {
                Console.Write($"Index {i}");
                foreach (var elem in hasitoTabla.elemek[i])
                {
                    Console.Write($" [{elem.Key}]");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
