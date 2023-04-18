
using Homework_5;

//Vezba 1

List<int> intList = new List<int>();

intList.Add(11);
intList.Add(22);
intList.Add(33);
intList.Add(44);
intList.Add(55);

foreach (int i in intList)
{
	Console.WriteLine(i);
}

Console.WriteLine("**********************\n");

//Vezba 2

List<String> StringList = new List<String>();

StringList.Add("Now");
StringList.Add("or");
StringList.Add("never.");

foreach (String str in StringList)
{
	Console.WriteLine(str);
}

Console.WriteLine("**********************\n");

//Vezba 3

List<int> Sumint = new List<int>();

Sumint.Add(1);
Sumint.Add(2);
Sumint.Add(3);
Sumint.Add(4);
Sumint.Add(5);

int sum = 0;
foreach (int i in Sumint)
{
	sum += i;
}

Console.WriteLine(sum);

//Vezba 4
Console.WriteLine("**********************\n");

List<int> SumOfNumbers = new List<int>();

for(int i = 0; i < 5; i++)
{
	Console.WriteLine("Enter five numbers: ", i+1);
	int num = int.Parse(Console.ReadLine());
	SumOfNumbers.Add(num);
}

int suma = 0;
foreach (int num in SumOfNumbers)
{
	suma += num;
}

Console.WriteLine("The sum of the numbers is: " + suma);

//Vezba 5
Console.WriteLine("**********************\n");

List<string> StringLine = new List<string>();

for (int i = 0; i < 10; i++)
{
	Console.WriteLine("Enter a word: ", i+1);
	string word = Console.ReadLine();
	StringLine.Add(word);
}

Console.WriteLine("The words you have entered are: ");

foreach (string word in StringLine)
{
	Console.WriteLine(word);
}
