using OOP_InstantiatedClassesSample;
/// ProTip:In general, instantiated classess store data.
/// Static classes are stateless proseccing.  

/// Building a house from blueprint

//PersonModel person = new PersonModel();
//person.firstName = "Pouria";
//PersonModel secondPerson = new PersonModel();
//secondPerson.firstName = "Peter";
//Console.WriteLine(person.firstName);
//Console.WriteLine(secondPerson.firstName); 

/// Variable holds the street address
//List<PersonModel> people = new List<PersonModel>();

//PersonModel person = new PersonModel();
//person.FirstName = "Sam";
//people.Add(person);

//person = new PersonModel();
//person.FirstName = "Lili";
//people.Add(person);

//foreach (PersonModel item in people)
//{
//    Console.WriteLine(item.FirstName);
//}

List<PersonModel> people = new List<PersonModel>();
string firstName = "";
do
{
    Console.WriteLine("What is your name (or type exit to stop): ");
    firstName = Console.ReadLine();
    if (firstName.ToLower() != "exit")
    {
        PersonModel person = new PersonModel();
        person.FirstName = firstName;
        people.Add(person);
    }

} while (firstName.ToLower() != "exit");
foreach (PersonModel item in people)
{
    ProcessPerson.GreetPerson(item);
}
Console.ReadLine();