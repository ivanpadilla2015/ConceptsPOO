
using POOConcepts;

Console.WriteLine("Hello, World!");

try //Ctrl + KS escogemos el try 
{
    Date date1 = new Date(2022, 5, 5);
    Console.WriteLine(date1);
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 11, 31));

}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}
