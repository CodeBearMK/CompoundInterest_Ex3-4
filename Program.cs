namespace CompundInterest_Ex3_4
{
    class Program
    {
        private static double compute(double m, double ar, double y)
        {
            double base_num = (1 + (ar / 100) / 12);
            double base_year = 12 * y;
            double compounding = (m * Math.Pow(base_num, base_year));
            return Math.Round(compounding, 2); //本利和
        }
        static void Main(string[] args)
        {
            double principal = 0; //本金
            double annualrate = 0; //年利率
            double yearsofdeposit = 0; //存款年數

            Console.Write("1. 請輸入本金：");
            principal = double.Parse(Console.ReadLine());
            Console.Write("2. 請輸入年利率(%)：");
            annualrate = double.Parse(Console.ReadLine());
            Console.Write("3. 請輸入存款年數：");
            yearsofdeposit = double.Parse(Console.ReadLine());

            Console.WriteLine("本利和為： {0} 元", compute(principal, annualrate, yearsofdeposit));
            Console.Read();
        }
    }
}