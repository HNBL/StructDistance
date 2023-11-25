public struct Distance
{
    public int inch;
    public int feet;
    public int Sum;

}
class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("Ведите первое  расстояние ");
        Distance d1;
        Distance d2;
        Distance z;
        Distance z2;
        Console.WriteLine("Ведите значние Фута ");
        d1.feet = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ведите значние Дюйма ");
        d1.inch = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ведите второе  расстояние ");
        d2.feet = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ведите значние Фута ");
        d2.inch = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ведите значние Дюйма ");


         z.Sum = (d1.feet + d2.feet) + (d1.inch + d2.inch) / 12;
        z2.Sum = (d1.inch + d2.inch) % 12;
        
        
        
        Console.WriteLine(" Результат {0}' - {1}\"",z.Sum, z2.Sum);

        Console.Read();
    }


}


