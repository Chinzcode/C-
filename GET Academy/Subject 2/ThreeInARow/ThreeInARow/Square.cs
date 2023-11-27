namespace ThreeInARow
{
    internal class Square 
    {
        //Declaring object variables
        private bool isBlank = true;
        private bool isPlayer1 = false;

        public bool IsEmpty()
        {
            return isBlank;
        }

        public bool IsPlayer1()
        {
            return isPlayer1;
        }

        public void Mark(bool player1)
        {
            if (isBlank)
            {
                isBlank = false;
                isPlayer1 = player1;
            }
        }
    }
}
