/*
    - Sammensatt objekt. Et objekt inni et annet objekt. 

 */


namespace IntroToClassesFromJS.V2
{
    internal class Demo2CompositeObject
    {
        public static void Run()
        {
            var model = new Model
            {
                Person = new Person
                {
                    FirstName = "Trym",
                    BirthYear = 1998
                }
            };
        }
    }
}
