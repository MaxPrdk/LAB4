namespace ThirdTask
{
    internal class task3
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            Tablet tablet = new Tablet();
            Laptop laptop = new Laptop();
            phone.ShowPoperties();
            Tablet.ShowPoperties();
            Laptop.ShowPoperties();   
        }
    }
}