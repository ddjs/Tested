namespace TestCode
{
    using System;
    using System.Diagnostics;

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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(SentenceMaker.Generate());
            }

            const int Length = 10;
            const int Index = 4;

            // our expected value should be our Length - our expected index.
            const int ExpectedValue = Length - Index;

            // generate linked list of the passed length,
            // function will return the first node in the list[head].
            var head = LinkedList.Generate(Length);
            
            // get the node at the passed index.
            var node = LinkedList.Nodes.GetNodeAtIndexFromEnd(Index, head);

            // test the value of the node equals our expected value.
            Debug.Assert(node.Value.Equals(ExpectedValue), "node.value doesnt equal expected value");

            // write the value to the console.
            Console.WriteLine(node.Value);
            Console.WriteLine("Press Enter To Exit.");
            Console.ReadLine();
        }
    }
}
