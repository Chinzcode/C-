using GETStudent;

var student = new StudentStatus();
string changeStr = "Levert dokumentasjon";
Console.WriteLine("Status: " + student.GetCurrentStatus());

if (student.SetCurrentStatus(changeStr))
{
    Console.WriteLine("Endret status til: " + student.GetCurrentStatus());
}
else
{
    Console.WriteLine(changeStr + " er et ugyldig statusbytte.");
}

Console.WriteLine("Status: " + student.GetCurrentStatus());

string earlierStatus = "Startet";
bool checkEarlierStatus = student.HasHadStatus(earlierStatus);

if (checkEarlierStatus)
{
    Console.WriteLine(earlierStatus + " er en tidligere status.");
}
else
{
    Console.WriteLine(earlierStatus + " er ikke en tidligere status.");
}