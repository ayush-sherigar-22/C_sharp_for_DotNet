namespace StackExercise
{
    public class Stack<T>
    {
        private readonly List<T> _stackList = [];

        public void Push(T item)
        {
            if (item != null)
            {
                _stackList.Add(item);
            }
            else
            {
                throw new ArgumentNullException("Cannot add null object to Stack");
            }
        }

        public T Pop() {

            if(_stackList.Count == 0)
            {
                throw new InvalidOperationException("Stack is Empty");
            }
            var index = _stackList.Count - 1;
            var value = _stackList[index];
            _stackList.RemoveAt(index);
            return value;
        }

        public void Clear() => _stackList.Clear();

    }
}