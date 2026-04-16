using System;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var list = new Stack<string>();
            list.Push("Apple");
            list.Push("Kiwi");
            list.Push("Guava");
            
            Console.WriteLine("List is :");
            list.DisplayStack();
            Console.WriteLine("Adding new item to list : ");
            list.Push("Banana");
            list.DisplayStack();

            Console.WriteLine("Using Peek : "+ list.Peek());
            Console.WriteLine("Using Pop : "+ list.Pop());
            list.DisplayStack();

            Console.WriteLine("Clearing List ");
            list.ClearStack();
            list.DisplayStack();
        }

    }

    public class Stack<T> 
    {
        private readonly List<T> _stack = new List<T>();

        

        public void Push(T item)
        {
            if(item == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            _stack.Add(item);
        }

        public T Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            
                var index = _stack.Count - 1;
                var value = _stack[index];
                _stack.RemoveAt(index);
                return value;
           

        }

        public T Peek()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return _stack[_stack.Count-1];

        }

        public void ClearStack()
        {
            _stack.Clear();
        }

        public void DisplayStack()
        {
            if (_stack.Count == 0)
            {
                Console.WriteLine("Stack us Empty");
            }
            foreach (var item in _stack) Console.WriteLine(item);

        }
    }
}