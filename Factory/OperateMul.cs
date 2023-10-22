namespace Factory
{
    // 定义一个OperateMul类，继承自Operate类
    public class OperateMul : Operate
    {
        // 重写Calculate方法
        public override void Calculate()
        {
            // 计算Num1和Num2的乘积
            Result = Num1 * Num2;
        }
    }
}