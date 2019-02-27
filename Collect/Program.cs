using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collect
{
    class Program
    {
        static void Main(string[] args)
        {
            Exmpl05();
        }
        static void Exmpl01()
        {
            ArrayList arr = new ArrayList();
            arr.Add(5);
            arr.Add("test");
            arr.Add(true);
            //arr[0] = 556;

            foreach (var item in arr)
            {
            }

            arr.Remove(5); // удаляет объект
            arr.RemoveAt(0); //удаляет индекс
            arr.RemoveRange(0, 2); //удаляет расстояние от куда и до куда
        }
        static void Exmpl02()
        {
            Queue queue = new Queue();
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }
            Console.WriteLine("Очередь");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            var t = queue.Peek(); //Кто следующий
            Console.WriteLine("Очередь после");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        static void Exmpl03()
        {
            Stack stack = new Stack();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine("collections");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            var t = stack.Pop();
            Console.WriteLine("collections after");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
        static void Exmpl04()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Asslan");
            keyValuePairs.Add(2, "Yevgen");
            if (keyValuePairs.ContainsKey(2))
            {
                keyValuePairs.Add(3, "Diass");
            }
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine("KEY: {0}, VALUE: {1}", item.Key, item.Value);
            }
        }
        static void Exmpl05()
        {
            LinkedList<string> vs = new LinkedList<string>();
            vs.AddFirst("Yevgen");
            vs.AddFirst("Dias");
            vs.AddFirst("Asslan");
            LinkedListNode<string> node; //node Хранит в себе не список а элемент
            for (node = vs.First; node != null; node = node.Next)
            {

                Console.WriteLine(node.Value);
            }
          
        }
    }
    
}
