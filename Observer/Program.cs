using System;
using System.Threading;

namespace ObserverPattern
{
    static class Program
    {
        public class Light : Subject
        {
            public string color = "red";

            public void ChangeColor()
            {
                switch (color)
                {
                    case "red":
                        color = "green";
                        break;
                    case "green":
                        color = "red";
                        break;
                    default:
                        this.color = "red";
                        break;
                }
                Publish();
            }
        }

        public class Car : Observer
        {
            public string name;
            public string status;

            public override void Update(Subject subject)
            {
                switch ((subject as Light).color)
                {
                    case "red":
                        status = "Stop!";
                        break;
                    case "green":
                        status = "Go!";
                        break;
                }
            }
        }

        static void Main()
        {
            Car car0 = new Car();
            Car car1 = new Car();
            Car car2 = new Car();
            car0.name = "小轿车";
            car1.name = "小货车";
            car2.name = "大货车";
            Light light = new Light();
            light.AddObserver(car0);
            light.AddObserver(car1);
            light.AddObserver(car2);

            // 在循环之前等待一段时间
            Thread.Sleep(5000);

            while (true)
            {
                light.ChangeColor();
                Console.WriteLine("灯状态为: " + light.color);
                Console.WriteLine("小轿车状态为: " + car0.status);
                Console.WriteLine("小货车状态为: " + car1.status);
                Console.WriteLine("大货车状态为: " + car2.status);
                Console.WriteLine("------------------------------------");
                Thread.Sleep(5000);
            }
        }
    }
}
