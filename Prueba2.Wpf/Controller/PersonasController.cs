using Pureba2.Wpf.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pureba2.Wpf.Controller
{
    public class PersonasController: IPersonasController
    {
        private List<Persona> ListaPersonas;
        public PersonasController()
        {
            ListaPersonas = new List<Persona>();
            ListaPersonas.Add(new Persona() { Nombre = "Mario", Apellido = "Ortega", Edad = 50 });
            ListaPersonas.Add(new Persona() { Nombre = "Mariano", Apellido = "Perez", Edad = 50 });
            ListaPersonas.Add(new Persona() { Nombre = "Blanca", Apellido = "Lopez", Edad = 51 });
        }
        public void DeletePersona(int id)
        {
            var persona = Get(id);
            ListaPersonas?.Remove(persona);
        }

        public Persona Get(int id) => ListaPersonas.FirstOrDefault(i => i.Id == id);
        public List<Persona> GetAll() => ListaPersonas;
        public void InsertarPersona(Persona persona) => ListaPersonas.Add(persona);
        public void UpdatePersona(Persona persona)
        {
            var personaLM = Get(persona.Id);
            if (personaLM != null)
            {
                personaLM.Nombre = persona.Nombre;
                personaLM.Apellido = persona.Apellido;
                personaLM.Edad = persona.Edad;
            }
        }
    }
}
