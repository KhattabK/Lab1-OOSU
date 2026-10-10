namespace Models
{
    public abstract class Användare
    {
        public string Användarnamn { get; private set; }
        private string Lösenord;
        public string Förnamn { get; private set; }
        public string Efternamn { get; private set; }
        public string Epost { get; private set; }

        protected Användare(string användarnamn, string lösenord, string förnamn, string efternamn, string epost)
        {
            Användarnamn = användarnamn;
            Lösenord = lösenord;
            Förnamn = förnamn;
            Efternamn = efternamn;
            Epost = epost;
        }

        // Lösenordet lämnas aldrig ut, det kan bara kontrolleras
        public bool KontrolleraLösenord(string lösenord)
        {
            return Lösenord == lösenord;
        }

        public string FullständigtNamn => $"{Förnamn} {Efternamn}";

        // Abstrakt: varje subklass måste själv ange sin roll (polymorfism)
        public abstract string Roll { get; }
    }
}