namespace MyApp;


public class Program{

    public static void Main(string[] args){
        var input = Console.ReadLine();
        var res = BoolConverter(IsLeapYear(Int32.Parse(input)));
        Console.WriteLine(res);
    }

    public static bool IsLeapYear(int year){
        
        if (year % 100 == 0){
            if(year % 400 == 0){
                return true;
            }
            return false;
        }
        return year % 4 == 0;
    }


    public static string BoolConverter(bool isLeapYear, string ifTrue = "yay", string ifFalse = "nay"){
        if (isLeapYear){
            return ifTrue;
        }
        return ifFalse;
    }
}