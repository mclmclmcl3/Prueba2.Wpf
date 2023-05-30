using System;

namespace Pureba2.Wpf.Messages
{
    public class EventUpdate
    {
        public event Action ParameterPassed;
        public void PublishParameter()
        {
            ParameterPassed?.Invoke();
        }
    }
}
