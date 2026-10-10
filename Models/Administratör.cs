namespace Models
{
    public class Administratör : Användare
    {
        public Administratör(string användarnamn, string lösenord, string förnamn, string efternamn, string epost)
            : base(användarnamn, lösenord, förnamn, efternamn, epost)
        {
        }

        public override string Presentera()
        {
            return $"Administratör: {Förnamn} {Efternamn}";
        }
    }
}