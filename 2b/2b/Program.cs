// See https://aka.ms/new-console-template for more information


Console.WriteLine("Select exercise");
int selectedIndex = Convert.ToInt32(Console.ReadLine()); 

switch(selectedIndex)
{
    case 1:
        one();
        break;
    case 2:
        two();
        break;
    case 3:
        three();
        break;
    case 4:
        four();
        break;
    case 5:
        five();
        break;
    case 7:
        seven();
        break;
    default:
        Console.WriteLine("Wrong value");
        break;
}





//1
void one()
{
    String myName = "Prodromos";
    Console.WriteLine("Hello " + myName);
}


//2

void two()
{
    Console.WriteLine("Give a number");
    string firstNumberString = Console.ReadLine();
    Console.WriteLine("Give a second number");
    string secondNumberString = Console.ReadLine();

    int firstNumber = Convert.ToInt32(firstNumberString);
    int secondNumber = Convert.ToInt32(secondNumberString);
    int add = firstNumber + secondNumber;
    int divide = firstNumber / secondNumber;

    string strSum = "The sum of " + firstNumberString + " and " + secondNumberString + " is " + add;
    Console.WriteLine(strSum);

    string strDiv = "The div of " + firstNumberString + " and " + secondNumberString + " is " + divide;
    Console.WriteLine(strDiv);
}


//3

void three()
    {
    int result1 = -1 * 5 + 6;
    Console.WriteLine(result1);

    int result2 = 38 + 5 % 7;
    Console.WriteLine(result2);

    double result3 = 14 + (-3 * 6 / 7);
    Console.WriteLine(result3);

    double result4 = 2 + (13 / 6) * 6 + Math.Sqrt(7);
    Console.WriteLine(result4);

    }



//4
//Console.WriteLine("Give me your gender");
//string gender = Console.ReadLine();
//Console.WriteLine("Age:");
//int age = Convert.ToInt32(Console.ReadLine());
//string str4 = "You are " + gender + " and you look younger than " + age;
//Console.WriteLine(str4);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

void four()
{
    Console.WriteLine("Type your gender via number");


    int counter = 0;
    foreach (string i in Enum.GetNames(typeof(GenderEnum)))
    {

        Console.WriteLine($"{i} : {counter}");
        counter++;
    }

    int genderNumber = Convert.ToInt32(Console.ReadLine());

    if (genderNumber < 3 && genderNumber >= 0)
    {
        Console.WriteLine("You are " + (GenderEnum)genderNumber);
    }
    else
    {
        Console.WriteLine("Type the correct number");
    }
}



//5

void five()
{
    Console.Write("Seconds : ");
    double seconds = Convert.ToDouble(Console.ReadLine());



    double minutes = seconds / 60;
    Console.WriteLine("Minutes: " + minutes);

    double hours = minutes / 60;
    Console.WriteLine("Hours: " + hours);

    double days = hours / 24;
    Console.WriteLine("Days: " + days);

    double years = days / 365;
    Console.WriteLine("Years: " + years);

    six(seconds);
}


//6

void six(double seconds)
{
    Console.WriteLine(".NET LIBRARIES");

    TimeSpan t = TimeSpan.FromSeconds(seconds);
    string answer = t.ToString(@"hh\:mm\:ss\:fff");

    Console.WriteLine();
    Console.WriteLine(answer);
}




//7

void seven()
{
    Console.Write("Enter temperature in Celsius: ");
    double celsius = Convert.ToDouble(Console.ReadLine());
    double fahrenheit = ((celsius * 9) / 5) + 32;
    Console.WriteLine("Fahreneit : " + fahrenheit);

}





public enum GenderEnum
{
    Male,
    Female,
    Other
}






