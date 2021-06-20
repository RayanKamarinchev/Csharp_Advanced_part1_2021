
using System.Text;

namespace _08.CarSaleman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Model}:");
            sb.AppendLine(Engine.ToString());
            sb.AppendLine(Weight == 0 ? "  Weight: n/a" : $"  Weight: {Weight}");
            sb.AppendLine(string.IsNullOrEmpty(Color) ? "  Color: n/a" : $"  Color: {Color}");
            return sb.ToString().TrimEnd();
        }
    }
}
