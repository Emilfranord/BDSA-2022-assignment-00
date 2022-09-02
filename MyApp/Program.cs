namespace MyApp;


public class Program{

    public static void Main(string[] args){
        var input = Console.ReadLine();
        if (input == null){
            return;
        }
        var res = BoolConverter(IsLeapYear(input));
        Console.WriteLine(res);
    }

    public static bool IsLeapYear(String year){
        return IsLeapYear(Int32.Parse(year));
    }

    public static bool IsLeapYear(int year){
        if(year < 1582 ){
            throw new ArgumentException();
        }

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