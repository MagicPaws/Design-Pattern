namespace Strategy;

public class FlyBehavior
{
    public virtual void Fly()
    {
        Console.WriteLine("我是一只能飞的鸭子");
    }
}

public class FlyWithNoWayBehavior : FlyBehavior
{
    public override void Fly()
    {
        Console.WriteLine("我是一只不会飞的鸭子");
    }
}

public class DisplayBehavior
{
    public virtual void Display()
    {
        Console.WriteLine("我是一只默认颜色的鸭子");
    }
}

public class WhiteBehavior : DisplayBehavior
{
    public override void Display()
    {
        Console.WriteLine("我是一只白色的鸭子");
    }
}

public class RedBehavior : DisplayBehavior
{
    public override void Display()
    {
        Console.WriteLine("我是一只红色的鸭子");
    }
}

public class SwimBehavior
{
    public virtual void Swim()
    {
        Console.WriteLine("我是一只会游泳的鸭子");
    }
}

public class SwimWithNoWayBehavior : SwimBehavior
{
    public override void Swim()
    {
        Console.WriteLine("我是一只不会游泳的鸭子");
    }
}

public class RunBehavior
{
    public virtual void Run()
    {
        Console.WriteLine("我是一只会跑的鸭子");
    }
}