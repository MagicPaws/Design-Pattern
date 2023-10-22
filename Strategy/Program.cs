using Strategy;

static class Program
{
    static void Main()
    {
        // 创建一个鸭子对象，它有飞、游泳、Run和显示的行为
        Duck duck = new Duck(new FlyBehavior(), new SwimBehavior(), new RunBehavior(),new WhiteBehavior());
        // 调用鸭子的游泳方法
        duck.Swim();
        // 调用鸭子的飞方法
        duck.Fly();
        // 调用鸭子的Run方法
        duck.Run();
        // 调用鸭子的显示方法
        duck.Display();
    }
}