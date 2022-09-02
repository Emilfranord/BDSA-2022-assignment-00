namespace MyApp;


public class Program{

    public static void Main(string[] args){
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
}