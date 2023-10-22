namespace Factory
{
    public class OperateFactory
    {
        public static Operate OpreateCreate(string op)
        {
            Operate operate = null;
            switch (op)
            {
                case "+":
                    operate = new OperateAdd();
                    break;
                case "-":
                    operate = new OperateSub();
                    break;
                case "*":
                    operate = new OperateMul();
                    break;
                case "/":
                    operate = new OperateDiv();
                    break;
                default:
                    Console.WriteLine("不支持该运算符,默认返回加法运算");
                    operate = new OperateAdd();
                    break;
            }

            return operate;
        }
    }
}