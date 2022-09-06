namespace Program;

public class Program{

    public static void Main(string[] args){
        Console.WriteLine("Enter year: ");
        var leapYear = new LeapYear();
        string leapYearAsString = Console.ReadLine();
        int year;
        bool parseSuccess = int.TryParse(leapYearAsString, out year);
        if(!parseSuccess){ //check if it is the right format etc. int
            Console.WriteLine("This is not an integer");
        }
        leapYear.NotALeapYear(year);
        if(leapYear.IsLeapYear(year) == true){
            Console.WriteLine("Yay");
        } else{
            Console.WriteLine("nayy");
        }
    }
}
