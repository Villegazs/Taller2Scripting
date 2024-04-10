namespace EventHandler
{
    public class Order
    {
        public string Item { get; set; }
        public string Ingredients { get; set; }
    }

    public class FoodPreparedEventArgs : EventArgs
    {
        public Order Order { get; set; }
    }

    public class FoodOrderingService
    {
        public event EventHandler<FoodPreparedEventArgs> FoodPrepared;

        public void PrepareOrder(Order order)
        {
            Console.WriteLine($"Preparing your order '{order.Item}', please wait...");
            Thread.Sleep(4000);

            OnFoodPrepared(order);
        }

        protected virtual void OnFoodPrepared(Order order)
        {
            FoodPrepared?.Invoke(this, new FoodPreparedEventArgs { Order = order });
        }
    }
    public class AppService
    {
        public void OnFoodPrepared(object source, FoodPreparedEventArgs eventArgs)
        {
            Console.WriteLine($"AppService: your food '{eventArgs.Order.Item}' is prepared.");
        }
    }
    public class MailService
    {
        public void OnFoodPrepared(object source, FoodPreparedEventArgs eventArgs)
        {
            Console.WriteLine($"MailService: your food '{eventArgs.Order.Item}' is prepared.");
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

            orderingService.FoodPrepared -= appService.OnFoodPrepared;
            orderingService.FoodPrepared -= mailService.OnFoodPrepared;

            orderingService.PrepareOrder(order);

            Console.ReadKey();
        }
    }
}
