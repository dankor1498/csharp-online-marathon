using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Sprint03
{
    class EventProgram
    {
        public event EventHandler Show;
        public EventProgram()
        {
            CreateEventList();
            Show?.Invoke(null, EventArgs.Empty);
        }

        void CreateEventList()
        {
            Show += Dog;
            Show += Cat;
            Show += Mouse;
            Show += Elephant;
        }

        public void Dog(object sender, EventArgs args) => Console.WriteLine("Dog");
        public void Cat(object sender, EventArgs args) => Console.WriteLine("Cat");
        public void Mouse(object sender, EventArgs args) => Console.WriteLine("Mouse");
        public void Elephant(object sender, EventArgs args) => Console.WriteLine("Elephant");
    }
}
