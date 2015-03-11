namespace TestCode
{
    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            var head = LinkedList.Generate(10);

            var node = LinkedList.Nodes.GetNodeAtIndexFromEnd(1, head);

            System.Console.WriteLine(node.Value);

            System.Console.WriteLine("Press Enter To Exit.");

            System.Console.ReadLine();
        }
    }
}
