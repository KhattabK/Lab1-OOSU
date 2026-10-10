namespace Models
{
    public abstract class Användare
    {
        public string Användarnamn { get; private set; }
        private string Lösenord;
        public string Förnamn { get; private set; }
        public string Efternamn { get; private set; }
        public string Epost { get; private set; }

        public Användare(string användarnamn, string lösenord, string förnamn, string efternamn, string epost)
        {
            Användarnamn = användarnamn;
            Lösenord = lösenord;
            Förnamn = förnamn;
            Efternamn = efternamn;
            Epost = epost;
        }

        // Lösenordet kan bara kontrolleras, aldrig läsas utifrån
        public bool KontrolleraLösenord(string lösenord)
        {
            return Lösenord == lösenord;
        }

        // Varje subklass presenterar sig på sitt eget sätt
        public abstract string Presentera();
    }
}