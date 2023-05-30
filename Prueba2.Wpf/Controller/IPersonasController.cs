using Pureba2.Wpf.Models;
using System.Collections.Generic;

namespace Pureba2.Wpf.Controller
{
    public interface IPersonasController
    {
        void DeletePersona(int id);
        Persona Get(int id);
        List<Persona> GetAll();
        void InsertarPersona(Persona persona);
        void UpdatePersona(Persona persona);
    }
}
