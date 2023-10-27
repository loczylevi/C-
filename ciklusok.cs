using System; 

public class Program {

  public static void Main(string[] args) {
    int myInt = 9;
    double myDouble = myInt;       // kicsiből nagy

    Console.WriteLine(myInt);      // Outputs 9
    Console.WriteLine(myDouble);   // Outputs 9
    
    double mDouble = 9.78;
    int mInt = (int) mDouble;    // nagyból kicsi

    Console.WriteLine(myDouble);   // Outputs 9.78
    Console.WriteLine(mInt);      // Outputs 9


    int cuccmok = 9;
    double c = (double) cuccmok;
    Console.WriteLine(c); 
    //_________________________________________________
    int szam = 69;
    double dupla = 6.66;
    bool igaz = true;
    Console.WriteLine(igaz);
    Console.WriteLine(Convert.ToString(szam));    // convert int to string
    Console.WriteLine(Convert.ToDouble(szam));    // convert int to double
    Console.WriteLine(Convert.ToInt32(dupla));  // convert double to int
    Console.WriteLine(Convert.ToString(igaz));   // convert bool to string
    
    // Create a string variable and get user input from the keyboard and store it in the variable
    /*
    Console.Write("kérem a neved: ");
    string userName = Console.ReadLine();

    // Print the value of the variable (userName), which will display the input value
    Console.WriteLine("Username is: " + userName);

    string bekeres = Console.ReadLine();  
    Console.WriteLine($"felhasználó név: {bekeres}");  

    */

  
    while (true) {
        try{
        Console.Write("Kérek egy számot:\t");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age > 0 && age < 100) {
            Console.WriteLine("ez a szám nagyobb 0 nál DE kisebb 100 nál\n");} 
      
        else if (age > 100) {
            Console.WriteLine("ez a szám 100 nál nagyobb\n");} 

          else if (age < 0){
            Console.WriteLine("ez minusz szám\n");}
          
        else if (age == 0) {
            Console.WriteLine("nulla\n"); }
          
        else {
            Console.WriteLine("ez a szám 100\n"); }
          }
    
        catch (Exception e){
      Console.WriteLine("karakterláncokat ne adjá már meg pliz\n");}

}



    
    }
}
  
