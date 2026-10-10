using Models;

namespace Servicelager
{
    public class InloggningController
    {
        private Datalager datalager;

        public InloggningController(Datalager datalager)
        {
            this.datalager = datalager;
        }

        // Returnerar den inloggade användaren, eller null om uppgifterna är fel.
        // Returtypen är Användare, så det kan bli antingen en Student eller en Administratör.
        public Användare? LoggaIn(string användarnamn, string lösenord)
        {
            foreach (Student student in datalager.Studenter)
            {
                if (student.Användarnamn == användarnamn && student.KontrolleraLösenord(lösenord))
                {
                    return student;
                }
            }

            foreach (Administratör admin in datalager.Administratörer)
            {
                if (admin.Användarnamn == användarnamn && admin.KontrolleraLösenord(lösenord))
                {
                    return admin;
                }
            }

            return null;
        }

        // Registrerar en ny student. Returnerar null om något fält är tomt eller om användarnamnet redan finns.
        public Student? RegistreraStudent(string användarnamn, string lösenord, string förnamn, string efternamn, string epost, string telefonnummer)
        {
            if (användarnamn == "" || lösenord == "" || förnamn == "" || efternamn == "" || epost == "")
            {
                return null;
            }

            if (ÄrAnvändarnamnUpptaget(användarnamn))
            {
                return null;
            }

            Student nyStudent = new Student(användarnamn, lösenord, förnamn, efternamn, epost, telefonnummer);
            datalager.LäggTillStudent(nyStudent);
            return nyStudent;
        }

        private bool ÄrAnvändarnamnUpptaget(string användarnamn)
        {
            foreach (Student student in datalager.Studenter)
            {
                if (student.Användarnamn == användarnamn)
                {
                    return true;
                }
            }

            foreach (Administratör admin in datalager.Administratörer)
            {
                if (admin.Användarnamn == användarnamn)
                {
                    return true;
                }
            }

            return false;
        }
    }
}