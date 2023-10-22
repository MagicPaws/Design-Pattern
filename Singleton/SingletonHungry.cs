namespace Singleton;

/// <summary>
/// 饿汉式单例
/// 单例的实例，在类加载时就已经创建
/// </summary>
public class SingletonHungry
{
    //1.私有静态全局实例
    private static SingletonHungry instance = new SingletonHungry();
    //2.公开静态访问属性
    public static SingletonHungry Instance
    {
        get => instance;
    }
    //3.私有构造函数，防止外部new
    private SingletonHungry(){}
    //成员方法
    public void ShowHashCode()
    {
        Console.WriteLine("HashCode: " + this.GetHashCode());
    }
}