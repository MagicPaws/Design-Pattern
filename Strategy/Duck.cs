namespace Strategy;

// 定义鸭子类
public class Duck
{
    // 声明鸭子的飞行、游泳和Run方法
    private FlyBehavior _fly;
    private SwimBehavior _swim;
    private RunBehavior _run;
    private DisplayBehavior _displayBehavior;

    // 构造函数，传入鸭子的飞行、游泳和Run方法
    public Duck(FlyBehavior fly, SwimBehavior swim, RunBehavior run, DisplayBehavior displayBehavior)
    {
        _fly = fly;
        _swim = swim;
        _run = run;
        _displayBehavior = displayBehavior;
    }

    // 鸭子的飞行方法
    public void Fly()
    {
        _fly.Fly();
    }

    // 鸭子的游泳方法
    public void Swim()
    {
        _swim.Swim();
    }

    // 鸭子的Run方法
    public void Run()
    {
        _run.Run();
    }

    // 鸭子的显示方法
    public void Display()
    {
        _displayBehavior.Display();
    }
}