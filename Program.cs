
//1 topshiriq

System.Console.WriteLine("Minutni kiriting: ");
int enterHour = Convert.ToInt32(Console.ReadLine());
int hour = enterHour / 60;
int minuts = enterHour % 60;
System.Console.WriteLine($"{hour} : {minuts}");

//2 topshiriq

System.Console.WriteLine("yoshni kiriting; ");
int enterYear = Convert.ToInt32(Console.ReadLine());

if (enterYear >= 0 && enterYear <=12)
{
    System.Console.WriteLine("Bola");
}
else if(enterYear >= 13 && enterYear <= 19)
{
    System.Console.WriteLine("o\'smir");
}
else if(enterYear >= 20 && enterYear <= 59)
{
    System.Console.WriteLine("kattalar");
}
else
{
    System.Console.WriteLine("Qarilar");
}

//3 topshiriq

System.Console.Write("(0-100) Enter your first score: ");
int firstScore = Convert.ToInt32(Console.ReadLine());

System.Console.Write("(0-100) Enter your second score: ");
int secondScore = Convert.ToInt32(Console.ReadLine());

System.Console.Write("(0-100) Enter your third score: ");
int thirdScore = Convert.ToInt32(Console.ReadLine());

int betweenScore = (firstScore + secondScore + thirdScore) / 3; 

System.Console.WriteLine(betweenScore);

string result =
    betweenScore >= 80 && betweenScore <= 100
    ?"your level is \"Alo\""
    :(betweenScore >= 60 && betweenScore < 80)
        ?"your level is \"Yaxshi\""
        :(betweenScore >= 40 && betweenScore < 60)
            ?"your level is \"Qoniqarli\""
            :(betweenScore >= 0 && betweenScore < 40)
                ?"your level is \"Qoniqarsiz\""
                :"You entered wrong score, please pay attention!";

System.Console.WriteLine(result);

//4 topshiriq

System.Console.WriteLine("Taxmin qilingan sonni kiriting: ");
int raqam = Convert.ToInt32(Console.ReadLine());

Random randRaqam = new Random();
int numBer = randRaqam.Next(1,100);

System.Console.WriteLine($"Siz kiritgan son: {raqam} \nKompyuter o\'ylagan son esa: {numBer}");

string compareNum = 
    raqam > numBer
        ?"Siz katta son kiritdingiz!"
        :"Siz kichik son kiritdingiz";
System.Console.WriteLine(compareNum);


