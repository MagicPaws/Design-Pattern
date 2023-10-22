namespace Factory
{
    public class OperateDiv : Operate
    {
        public override void Calculate()
        {
            // 除法
            if (Num2 == 0)
            {
                throw new Exception("除数不能为0");
            }

            Result = Num1 / Num2;
        }
    }
}