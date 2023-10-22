namespace ObserverDelegate;

public delegate void ColorChanged(Light l);

public class Light
{
    public event ColorChanged ColorChanged;
    public string color;

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
                color = "red";
                break;
        }

        ShowStatus();
        if (ColorChanged != null)
        {
            ColorChanged(this);
        }
    }

    private void ShowStatus()
    {
        Console.WriteLine("当前红路灯为:" + color + "");
    }
}

public class Car
{
    public string name;
    public string status;

    public void Stop()
    {
        status = "stop";
        ShowStatus();
    }

    public void Go()
    {
        status = "go";
        ShowStatus();
    }

    private void ShowStatus()
    {
        Console.WriteLine("{0} 状态为 {1}", name, status);
    }
}