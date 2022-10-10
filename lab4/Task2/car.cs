namespace SecondTask
{
    public abstract class Car
    {
        protected int speed;
        protected int condition;
        protected int price;

        public virtual int CalculateSpeed()
        {
            return speed;
        }

        public virtual void Repair()
        {
            condition += 30;
        }

        public virtual int Sell()
        {
            return price;
        }

        public virtual void ShowMethods()
        {
            Console.WriteLine(GetType().Name);
            foreach (var method in GetType().GetMethods())
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
        }
    }
}