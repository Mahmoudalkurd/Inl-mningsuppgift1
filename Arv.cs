namespace Inlämningsyppgift_1
{
    

    public class Animal
    {
        public string name;

        public void Eat()
        {
            Console.WriteLine("eating");
        }
        
    }

    public class Monkey : Animal
    {
        public void Steal()
        {
            Console.WriteLine("Monkey stole your keys...");
        }
    }
    
}
