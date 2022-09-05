namespace Program;

public class LeapYear{

    public bool IsLeapYear(int year){

        if(DateTime.IsLeapYear(year)){
            return true;
        }
        else
        {
            return false;
        }
        /*if(year % 4 == 0 || year % 400 == 0){
            return true;
        } 
        else if (year % 100 == 0)
        {
            return false;
        }
        else

            return false;
    */
    }

}