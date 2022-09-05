namespace Program;

public class Program{

    public static void Main(string[] args){
        Console.WriteLine("Enter year: ");
        var leapYear = new LeapYear();
        int year = Convert.ToInt32(Console.ReadLine());
        if(leapYear.IsLeapYear(year) == true){
            Console.WriteLine("Yay");
        } else{
            Console.WriteLine("nayy");
        }
    }
}
