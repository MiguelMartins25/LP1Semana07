using System;
using System.Globalization;

namespace PowerCell
{
    public class Cell
    {
        private float charge;

        public string Name { get; }

        public float Charge
        {
            get { return charge; }
            set
            {
                if (value < 0) charge = 0;
                else if (value > 200) charge = 200;
                else charge = value;
            }
        }

        public int Level
        {
            get { return 1 + (int)(Charge / 40); }
        }

        public Cell(string name)
        {
            Name = name;
            Charge = 200;
        }

        public void Consume(float amount)
        {
            Charge -= amount;
        }

        public void Restore()
        {
            Charge = 200;
        }

        // override do metodo ToString()
        public override string ToString()
        {
            return $"[{Name}] Level {Level}: {Charge}/200";
        }
    }
}