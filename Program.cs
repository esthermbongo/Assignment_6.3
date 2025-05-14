namespace Assignment_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueStack queue = new QueueStack();

            
            queue.AddLast(new Customers() { Id = 1, Name= "Alex", Description="Technical support"});
            queue.AddLast(new Customers() { Id = 2, Name = "Lee", Description="Order status"});
            queue.AddLast(new Customers() { Id= 3, Name="Noah", Description="Inquiry"});

            Console.WriteLine("Starting Queue: ");
            queue.Display();

            Console.WriteLine("First Customer Complete... Updating Queue...");
            queue.RemoveFirst();

            Console.WriteLine("Updated Queue:");
            queue.Display();

            queue.AddLast(new Customers() { Id=4, Name = "Mike", Description = "Refund"});

            Console.WriteLine("New customer added!: ");
            queue.Display();

            Console.ReadKey();
        }

    }
}
