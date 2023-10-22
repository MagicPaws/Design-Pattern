namespace Factory
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("请输入一个数字：");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入二个数字：");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入运算符号（+、-、*、/）：");
            var op = Console.ReadLine();
            //利用工厂生产对应的类
            Operate oper = OperateFactory.OpreateCreate(op);
            oper.Num1 = num1;
            oper.Num2 = num2;
            oper.Calculate();
            Console.WriteLine("结果为:" + oper.Result);
        }
    }
}