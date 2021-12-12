class Lasagna
{
    //"Lasagna.Expected minutes in oven" the fist word is the class and the word         after the "." is the parameter you want to know the value of
    public int ExpectedMinutesInOven() 
    {
        return 40;
    }

    //accepts parameter from user (elapsed_time) and then returns remaining time by subtracting from the expected time (40)
  public int RemainingMinutesInOven(int elapsed_time) 
    {
        return ExpectedMinutesInOven() - elapsed_time;
    }

    //prep time is 2mins per layer. Method takes input parameter of how many layers are required. Multiplication and then total prep time is returned
    
    public int PreparationTimeInMinutes(int layers) 
    {
        return layers * 2;
    }

    //take input paramters of layers and the elapsed time in oven and returns the total elapsed time so far
    
    public int ElapsedTimeInMinutes(int layers, int elapsed_time) 
    {
        return elapsed_time + PreparationTimeInMinutes(layers);
    }
}
