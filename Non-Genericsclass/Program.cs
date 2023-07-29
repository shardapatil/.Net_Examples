namespace Session
{
    public class Program
    {
        public object data;

        public string process(object input)
        {
            
            if (data == input)
                return "Same"; 
            else
                return "Not Same";
            return null;
        }

        class TestProgram
        {
            static void Main(string[] args)
            {
                Program p = new Program();
                p.data = 32;
                Console.WriteLine(p.process(32));

                Program pl = new Program();
                pl.data = "Apple";
                Console.WriteLine(pl.process("Apple"));
            }
        }
    }
}
