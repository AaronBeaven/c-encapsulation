using System;

namespace csharp_encapsulation
{
    class AreaClass{
         //declaring the variables
        public double width;
        public double length;
        public double age = 20;
        public string userInput;


// making the function 
        public double area()
        {
            return width * length;
        }

        public void informationDisplayed()
        {
            //logging the results 
            Console.WriteLine("width = {0}", width);
            Console.WriteLine("length = {0}", length);
            Console.WriteLine("our aree is = {0}", area());
        }
    public void UserDetails()
    {
        int myInt = 44;
        //converting the data into what they need to be in 
        if(Convert.ToBoolean(myInt)){
            Console.WriteLine(myInt);
        }
        //taking the users details and checking it againt 
        Console.WriteLine("please enter your details");
        userInput = Console.ReadLine();
        //if function checking age 
        if(Convert.ToDouble(userInput) == age)
        {
            Console.WriteLine("wow welcome aaron");
        };
    }
    
    }

    class Program
   {
        static void Main(string[] args)
        {
            //giving all the valies and calling the functions
            AreaClass myShape = new AreaClass();
            myShape.width = 12.94;
            myShape.length = 6.87;
            myShape.informationDisplayed();
            myShape.UserDetails();
            Console.ReadKey();
        }
    }
}
