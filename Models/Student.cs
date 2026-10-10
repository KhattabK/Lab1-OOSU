namespace Models
{
    public class Student : Användare
    {
        public string Telefonnummer { get; private set; }

        // Studentens egna annonser (krav i verksamhetsbeskrivningen)
        private List<Annons> minaAnnonser = new List<Annons>();
        public IReadOnlyList<Annons> MinaAnnonser => minaAnnonser;

        public Student(string användarnamn, string lösenord, string förnamn, string efternamn, string epost, string telefonnummer)
            : base(användarnamn, lösenord, förnamn, efternamn, epost)
        {
            Telefonnummer = telefonnummer;
        }

        public override string Roll => "Student";

        public void LäggTillAnnons(Annons annons)
        {
            if (!minaAnnonser.Contains(annons))
            {
                minaAnnonser.Add(annons);
            }
        }

        public void TaBortAnnons(Annons annons)
        {
            minaAnnonser.Remove(annons);
        }
    }
}