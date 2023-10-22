namespace Singleton;

/// <summary>
/// 懒汉式单例
/// 单例的实例，在类第一次被访问时才会被创建
/// </summary>
public class SingletonLazy
{
    //1.私有静态全局实例
    private static SingletonLazy? _instance;

    //创建锁，防止并发时多次创建
    private static readonly object _lock = new object();

    //2.公开静态访问属性,在属性获取时进行判断
    public static SingletonLazy Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonLazy();
                        return _instance;
                    }
                }
            }

            return _instance;
        }
    }

    //3.私有构造函数，防止外部new
    private SingletonLazy()
    {
    }

    //成员方法
    public void ShowHashCode()
    {
        Console.WriteLine("HashCode: " + this.GetHashCode());
    }
}