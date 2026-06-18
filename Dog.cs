

namespace Dogs;

public class Dog
{

    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }

   

    public void Bark()
    {
        if (Weight < 15)
            Console.WriteLine("Yip!");
        else
        {
            Console.WriteLine("WOOF!");
        }
    }
}
