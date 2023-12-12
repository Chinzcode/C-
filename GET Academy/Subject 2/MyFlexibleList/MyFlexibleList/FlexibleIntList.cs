namespace MyFlexibleList
{
    internal class FlexibleIntList
    {
        private int[] _numbers = new int[4];
        private int _count = 0;

        public void AddNumber(int number)
        {
            if (_count >= _numbers.Length)
            {
                var newNumbers = new int[_numbers.Length * 2];
                Array.Copy(_numbers, newNumbers, _numbers.Length);
                _numbers = newNumbers;
            }
            _numbers[_count] = number;
            _count++;
        }

        public string GetValues()
        {
            return string.Join(",", _numbers);
        }
    }
}