namespace CalcServiceProject.Models
{
    public class CalcService
    {
        public int Sum(int a, int b) => a + b;
        public int Multiply(int a, int b) => a * b;
        public int Subtract(int a, int b) => a - b;
        public float Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new System.Exception("divide on 0");
            }

            return a / b;
        }
    }
}
