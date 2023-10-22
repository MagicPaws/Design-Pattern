namespace Factory
{
    public class OperateSub : Operate
    {
        public override void Calculate()
        {
            // 计算两个数字的差
            Result = Num1 - Num2;
        }
    }
}