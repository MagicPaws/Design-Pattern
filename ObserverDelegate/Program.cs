using Microsoft.VisualBasic;
using ObserverDelegate;

static class Program
{
    static void Main()
    {
        Car car0 = new Car();
        Car car1 = new Car();
        Car car2 = new Car();
        car0.name = "小轿车";
        car1.name = "大轿车";
        car2.name = "跑车";
        List<Car> list = new List<Car>() { car0, car1, car2 };
        Light light = new Light();
        light.ColorChanged += (light) =>
        {
            if (light.color == "red")
            {
                foreach (var car in list)
                {
                    car.Stop();
                }
            }
            else
            {
                foreach (var car in list)
                {
                    car.Go();
                }
            }
        };
        while (true)
        {
            light.ChangeColor();            
            Thread.Sleep(5000);
        }
    }
}