namespace Program;

public class LeapYear{

    public bool IsLeapYear(int year){
    
        if(year < 1582){
            return false;
        }

        if(DateTime.IsLeapYear(year)){
            return true;
        }
        else
        {
            return false;
        }


        /*if(year % 4 == 0 && year % 400 != 0){
            return true;
        } 
        if(year % 4 == 0 && year 400 == 0){
            return true;
        }
            return false;
    */
    }

    public bool IsAnInteger(int year){
        if (int.TryParse(Console.ReadLine(), out year)){
            throw new Exception("Wrong input type");
        }
        return true;
        
    }


    public bool NotALeapYear(int year){
        if (year < 1582){
            throw new Exception("No leapyears before 1582");
        }
        return true;
    }
}