namespace ObserverPattern;

/* 策略模式
 * 定义一种一对多的依赖关系，让多个观察者对象同时监听某一个主题对象。这个主题对象在状态发生变化时，会通知所有观察者对象，使他们能够自动更新自己。
 * 红绿灯——红灯停绿灯行
 */

// 定义抽象类Subject
public abstract class Subject
{
    // 定义私有变量_observers
    private List<Observer> _observers = new List<Observer>();
    

    // 定义添加观察者方法
    public void AddObserver(Observer observer)
    {
        // 将观察者添加到_observers列表中
        this._observers.Add(observer);
    }
    // 定义发布方法
    public void Publish()
    {
        // 遍历_observers列表
        foreach (Observer observer in  _observers)
        {
            // 调用观察者的更新方法，传入当前对象
            observer.Update(this);
        }
    }
}