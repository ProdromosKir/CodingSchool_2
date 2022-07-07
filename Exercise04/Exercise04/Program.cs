using Exercise04;

Console.WriteLine("Choose Exercise");
int selectedIndex = Convert.ToInt32(Console.ReadLine());

switch(selectedIndex)
{
    case 1:
        Console.WriteLine("Give a string to be reversed");
        string s = Console.ReadLine();

        Class1 c = new Class1();
        c.ReverseString(s);
        break;
    case 2:
        Class2 c2 = new Class2();
        c2.ComputingSumAndProduct();
        break;
    case 3:
        Class3 c3 = new Class3();
        c3.FindPrimes();
        break;
    case 4:
        int[] Array1 = new int[] { 2, 4, 9, 12 };
        int[] Array2 = new int[] { 1, 3, 7, 10 };
        Class4 c4 = new Class4();
        c4.Multiply2Arrays(Array1,Array2);

        break;
    case 5:
        int[] GivenArray = new int[10] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
        Class5 c5 = new Class5();
        c5.SortIntArray(GivenArray);
        break;
    default:
        Console.WriteLine("Wrong Input");
        break;

}











    






