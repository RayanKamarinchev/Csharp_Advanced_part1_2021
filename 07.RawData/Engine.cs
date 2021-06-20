
namespace _07.RawData
{
    public class Engine
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private int power;

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
    }
}
