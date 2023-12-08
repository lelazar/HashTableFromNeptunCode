# Hash Tábla Implementáció (C#)

### Leírás
Ez a program egy egyszerű hash tábla implementációt tartalmaz C# nyelven. A tábla karaktereket használ kulcsként, és minden karakter ASCII kódját tárolja értékként. A tábla mérete 17, ami egy prímszám, így segít csökkenteni az ütközések számát a hash kódolás során.

### Használat
1. Hash Tábla Létrehozása: A HashTable osztály egy új hash táblát hoz létre, melynek mérete 17.
2. Karakter Hozzáadása: A Hozzaad metódus lehetővé teszi, hogy egy karaktert és annak ASCII kódját hozzáadjuk a táblához.
3. Hash Kód Lekérdezése: A TombPozicioLekeres metódus a megadott karakter hash kódját számítja ki.
4. Érték Lekérdezése: A Lekeres metódus segítségével lekérdezhető a táblában tárolt érték egy adott karakterhez.

### Program Működése
A Program osztály Main metódusában a "MRWFFP" Neptun kód karakterei kerülnek hozzáadásra a hash táblához. Minden karakterhez a hash kód és az érték kiírásra kerül. Ezen kívül a tábla teljes tartalma is kiírásra kerül, megmutatva, hogy mely karakterek kerültek mely indexekre.

### Implementációs Részletek
- **HashTable Osztály:** Ez az osztály kezeli a hash tábla műveleteit, beleértve az elemek hozzáadását és lekérdezését.
- **Meret:** A hash tábla mérete, ami jelen esetben 17.
- **Elemek:** Egy tömb, mely a kulcs-érték párokat tárolja.
- **Hozzaad Metódus:** Ez a metódus hozzáad egy kulcs-érték párt a hash táblához.
- **Lekeres Metódus:** A megadott kulcshoz tartozó értékek lekérdezésére szolgál.
