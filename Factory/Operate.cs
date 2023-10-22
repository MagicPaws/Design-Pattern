namespace Factory
{
    // 定义一个操作类
    public class Operate
    {
        // 定义两个数字变量
        public int Num1 { get; set; }

        public int Num2 { get; set; }

        // 定义一个结果变量
        public int Result { get; protected set; }

        // 定义一个计算方法
        public virtual void Calculate()
        {
            Result = 0;
        }
    }
}

