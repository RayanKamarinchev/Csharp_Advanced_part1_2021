using System;
using System.Collections;
using System.Collections.Generic;

namespace _04.VeryCuteFrog
{
    class Lake<T> : IEnumerable<T>
    {
        public List<T> Stones { get; set; }

        public void MoveFrog()
        {
            List<T> output = new List<T>();
            for (int i = 0; i < Stones.Count; i+=2)
            {
                output.Add(Stones[i]);
            }
            List<T> secondOutput = new List<T>();
            for (int i = 1; i < Stones.Count; i+=2)
            {
                secondOutput.Add(Stones[i]);
            }
            secondOutput.Reverse();
            Console.Write(string.Join(", ",output)+", ");
            Console.WriteLine(string.Join(", ", secondOutput));
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Stones)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
