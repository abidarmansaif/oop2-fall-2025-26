// See https://aka.ms/new-console-template for more information
class House
{
    public int YearBuilt { get; set; }
    public double Size { get; set; }

    public House(int yearBuilt, double size )
    {
        YearBuilt = yearBuilt;
        Size = size;
    }
    private int HowOld()
    {
        int CurrentYear=DateTime.Now.Year;
        int age = CurrentYear - YearBuilt;
        return age;
    }
    public bool CanBeSold()
    {
        int age = HowOld();
        if (age>15)
            return true;
        else
            return false;
       
        
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter built year: ");
        int Yearbuilt = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter size: ");
        double size = Convert.ToDouble(Console.ReadLine());

        House myHouse = new House(Yearbuilt, size);

        if (myHouse.CanBeSold())
        {
            Console.WriteLine("House can be sold");
           
        }
        else
        {
            Console.WriteLine("House can't be sold");
        }

    }
}