using Pureba2.Wpf.Models;
using System;

namespace Pureba2.Wpf.Messages
{
    public class MensajePersona
    {
        public event Action<Persona> ParameterPassed;
        public void PublishParameter(Persona persona)
        {
            ParameterPassed?.Invoke(persona);
        }
    }
}
