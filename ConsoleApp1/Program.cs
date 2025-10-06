
#region Fibanocci
//int frstnum = 0, secondnum = 1, n, i;

//for ( i = 2; i < 10; i++)
//{
//    n = frstnum + secondnum;
//    Console.WriteLine(n);
//    frstnum = secondnum;
//    secondnum = n;
//}
#endregion
#region AxtarilanEded
//var c = -1;
//int x = 8, y = 2;
//for (int i =x; i >0; i--)
//{
//    if (i%y == 0)
//    {
//        c = i;
//        break;
//    }
//}
//Console.WriteLine("Axtardiginiz eded" + " " + c + " " + "dir");
#endregion
#region Bolenleri
//int n = 10;

//for (int i=1; i <=n; i++)
//{
//    if (n%i==0)
//    {
//        Console.WriteLine(i);

//    }
//}
#endregion
#region MertebelerinSayi
//var mertebe = 0;
//Console.WriteLine("Ededi daxil edin");
//int a = Convert.ToInt32(Console.ReadLine());
//for (int i=a;i!=0;i/=10)
//{
//    if (i==0)
//    {
//        mertebe = 1;
//    }
//    mertebe++;
//}
//Console.WriteLine("Bu ededin mertebelerinin sayi " + " " + mertebe +" "+"dir");
#endregion
#region AyaGoreFesil
int a = 0;
restart:
Console.WriteLine("Ayi daxil edin");
string ay=Console.ReadLine();
ay = ay.ToLower();
switch (ay)
{
	case "yanvar": a=1;
		break;
    case "fevral":
        a = 2;
        break;
    case "mart":
        a = 3;
        break;
    case "aprel":
        a = 4;
        break;
    case "may":
        a = 5;
        break;
    case "iyun":
        a = 6;
        break;
    case "iyul":
        a = 7;
        break;
    case "avqust":
        a = 8;
        break;
    case "sentyabr":
        a = 9;
        break;
    case "oktyabr":
        a = 10;
        break;
    case "noyabr":
        a = 11;
        break;
    case "dekabr":
        a = 12;
        break;
    default:
        Console.WriteLine("Ay adini duzgun daxil edin");
		break;
}
if (a==12 ||a==1 || a==2)
{
    Console.WriteLine("Qis Feslidir");
}
else if (a==3||a==4||a==5)
{
    Console.WriteLine("Yaz Feslidir");
}
else if (a == 6 || a == 7 || a == 8)
{
    Console.WriteLine("Yay Feslidir");
}
else if (a == 9 || a == 10 || a == 11)
{
    Console.WriteLine("Payiz Feslidir");
}
else
{
    Console.Clear();
    Console.WriteLine("Ay adini duzgun daxil edin");

    goto restart;
}
#endregion