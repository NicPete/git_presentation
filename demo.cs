using System;
namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {
            HelloWorld();
        }
		
		static void HelloWorld()
		{
			Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
		}
    }
}