namespace MyFlexibleList
{
    internal class FlexibleList<T>
    {
        private T[] _values = new T[4];
        private int _count = 0;

        public void Add(T value)
        {
            if (_count >= _values.Length)
            {
                var newNumbers = new T[_values.Length*2];
                Array.Copy(_values, newNumbers, _values.Length);
                _values = newNumbers;
            }
            _values[_count] = value;
            _count++;
        }

        public string GetValues()
        {
            return string.Join(",", _values);
        }
    }
}
