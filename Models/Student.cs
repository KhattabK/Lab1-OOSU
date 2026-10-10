namespace Models
{
    public class Student : Användare
    {
        public string Telefonnummer { get; private set; }
        public List<Annons> MinaAnnonser { get; private set; }

        public Student(string användarnamn, string lösenord, string förnamn, string efternamn, string epost, string telefonnummer)
            : base(användarnamn, lösenord, förnamn, efternamn, epost)
        {
            Telefonnummer = telefonnummer;
            MinaAnnonser = new List<Annons>();
        }

        public override string Presentera()
        {
            return $"Student: {Förnamn} {Efternamn}";
        }

        public void LäggTillAnnons(Annons annons)
        {
            if (!MinaAnnonser.Contains(annons))
            {
                MinaAnnonser.Add(annons);
            }
        }

        public void TaBortAnnons(Annons annons)
        {
            MinaAnnonser.Remove(annons);
        }
    }
}