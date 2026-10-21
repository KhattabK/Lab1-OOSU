namespace Models
{
    public class Student : Användare
    {
        public string Telefonnummer { get; private set; }
      

        public Student(string användarnamn, string lösenord, string förnamn, string efternamn, string epost, string telefonnummer)
            : base(användarnamn, lösenord, förnamn, efternamn, epost)
        {
            Telefonnummer = telefonnummer;
          
        }

        public override string Presentera()
        {
            return $"Student: {Förnamn} {Efternamn}";
        }

        
    }
}