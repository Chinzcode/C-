namespace IntroToClassesFromJS.V3
{
    internal class Demo3CompositeWithArray
    {
        public static void Run()
        {
            var model = new Model
            {
                App = new App
                {
                    CurrentUser = "Trym",
                    CurrentPage = "Main",
                },
                People = new Person[]
                {
                    new Person
                    {
                        FirstName = "Trym",
                        BirthYear = 1998,
                    }
                }
            };
        }
    }
}
