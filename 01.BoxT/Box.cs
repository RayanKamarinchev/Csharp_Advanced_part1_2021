namespace _01.BoxT
{
    public class Box<T>
    {
        public Box(T type)
        {
            Element = type;
        }
        public T Element { get;}

        public override string ToString()
        {
            return $"{typeof(T)}: {Element}";
        }
    }
}
