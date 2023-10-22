namespace Factory
{
    public class OperateAdd : Operate
    {
        public override void Calculate()
        {
            // 计算两个数字的和
            Result = Num1 + Num2;
        }
    }
}