namespace Pureba2.Wpf.Models
{
    public class Persona
    {
        private static int miId = 0;
        public int Id { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public Persona()
        {
            miId++;
            Id = miId;
        }
    }
}
