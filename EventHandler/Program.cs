namespace EventHandler
{

    public class Order
    {
        public string Item { get; set; }
        public string Ingredients { get; set; }
    }
    public class FoodOrderingService
    {
        public delegate void FoodPreparedEventHandler(object source, EventArgs args);
        public event FoodPreparedEventHandler FoodPrepared;

        public void PrepareOrder(Order order)
        {
            Console.WriteLine($"Preparing your order '{order.Item}', please wait...");
            Thread.Sleep(4000);

            OnFoodPrepared();
        }

        protected virtual void OnFoodPrepared()
        {
            if (FoodPrepared != null)
                FoodPrepared(this, null);
        }
    }

    public class AppService
    {
        public void OnFoodPrepared(object source, EventArgs eventArgs)
        {
            Console.WriteLine("AppService: your food is prepared.");
        }
    }
    public class MailService
    {
        public void OnFoodPrepared(object source, EventArgs eventArgs)
        {
            Console.WriteLine("MailService: your food is prepared.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order { Item = "Pizza with extra cheese" };

            var orderingService = new FoodOrderingService();
            var appService = new AppService();
            var mailService = new MailService();

            orderingService.FoodPrepared += appService.OnFoodPrepared;
            orderingService.FoodPrepared += mailService.OnFoodPrepared;

            orderingService.PrepareOrder(order);

            Console.ReadKey();
        }
    }

}
