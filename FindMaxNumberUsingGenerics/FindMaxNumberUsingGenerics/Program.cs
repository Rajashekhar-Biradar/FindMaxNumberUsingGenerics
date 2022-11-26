using FindMaxNumberUsingGenerics;
using System.Net.Http.Headers;
using System.Net.Security;

Console.WriteLine("Choose an option to find the maximum number");
Console.WriteLine("1. Find integer maximum number among 3 numbers \n 2.Find Float maximum number among 3 numbers \n 3.Find maximum string among 3 string \n 4.Find maximum number among 3 numbers using Generic method \n 5.Find maximum number among 3 numbers using Generic Class");

int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        Console.WriteLine("Largest number is : "+Integer_FindMaxNumber.Find_Max_num(10, 20, 30));
        break;
    case 2:
        Console.WriteLine("Largest number is : "+Floats_FindMaxNum.Find_Max_num(10.5f, 20.5f, 30.5f));
        break;
    case 3:
        Console.WriteLine("largest string is : "+String_FindMaxNum.Find_Max_num("Apple", "Banana", "Peach"));
        break;
    case 4:
        //Console.WriteLine("Largest integer is : "+FindMaxNum_UsingGeneric.Find_Max_num(100, 200, 300));
        //Console.WriteLine("Largest Float num is : "+FindMaxNum_UsingGeneric.Find_Max_num(11.0f, 20.5f, 3.5f));
        //Console.WriteLine("Largest string is : "+FindMaxNum_UsingGeneric.Find_Max_num("Ram", "Laxman", "Raja"));
        break;
    case 5:
        Console.WriteLine("Largest integer is : " + FindMaxNum_UsingGenericClass<int>.Find_Max_num(100, 200, 300));
        Console.WriteLine("Largest Float num is : " + FindMaxNum_UsingGenericClass<float>.Find_Max_num(11.0f, 20.5f, 3.5f));
        Console.WriteLine("Largest string is : " + FindMaxNum_UsingGenericClass<string>.Find_Max_num("Ram", "Laxman", "Raja"));
        break;
        default:
        Console.WriteLine("Choose correct option");
        break;


}






