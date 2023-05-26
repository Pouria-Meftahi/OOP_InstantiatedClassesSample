namespace OOP_InstantiatedClassesSample
{
    public static class ProcessPerson
    {
        public static void GreetPerson(PersonModel person)
        {
            Console.WriteLine($"Hello {person}");
            person.HasBeenGreeted = true;
        }
    }
}
