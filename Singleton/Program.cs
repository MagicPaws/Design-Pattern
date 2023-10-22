/* 单例模式
 * 保证一个类仅有一个实例，并提供一个访问它的全局访问点。
 * 优点:全局公共资源共享实例可以节省运算资源，提高运行性能
 * 特殊场景中，对象实例只能存在一次，不能多次实例，否则会出现业务bug
*/
using Singleton;
SingletonHungry.Instance.ShowHashCode();
SingletonLazy.Instance.ShowHashCode();