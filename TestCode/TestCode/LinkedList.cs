namespace TestCode
{
    using System;

    /// <summary>
    /// The linked list.
    /// </summary>
    public class LinkedList
    {
        /// <summary>
        /// The generate linked list.
        /// </summary>
        /// <param name="count">
        /// The count.
        /// </param>
        /// <returns>
        /// The <see cref="Nodes"/>.
        /// </returns>
        public static Nodes Generate(int count)
        {
            // our reference to the current Node.
            Nodes previous = null;

            // our reference to the first Node.
            Nodes head = null;

            // loop until we reach out expected count of items.
            for (var index = 0; index < count; index++)
            {
                // create a new node and set the Value to our index + 1 for easier
                // debugging. 
                var current = new Nodes { Value = 1 + index };

                // if our first Item updat the head reference.
                if (index == 0)
                {
                    head = current;
                }

                // check if our previous reference has been set.
                // if so set our previous Node Pointer to the current Node.
                if (previous != null)
                {
                    previous.Pointer = current;
                }

                // set our previous to the current Node.
                previous = current;
            }

            return head;
        }

        /// <summary>
        /// The nodes.
        /// </summary>
        public class Nodes
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Nodes"/> class. 
            /// </summary>
            internal Nodes()
            {
            }

            /// <summary>
            /// Gets or sets The pointer.
            /// </summary>
            public object Pointer { get; set; }

            /// <summary>
            /// Gets or sets the value.
            /// </summary>
            public int Value { get; set; }

            /// <summary>
            /// The get node at index from end.
            /// </summary>
            /// <param name="index">
            /// The index.
            /// </param>
            /// <param name="head">
            /// The head.
            /// </param>
            /// <returns>
            /// The <see cref="Nodes"/>.
            /// </returns>
            public static Nodes GetNodeAtIndexFromEnd(uint index, Nodes head)
            {
                // variable to store our current index into the list.
                var currentIndex = 0;

                // set our current Node reference to the Head.
                var current = (Nodes)head.Pointer;

                // set our response Node reference to the Head.
                var response = (Nodes)head.Pointer;

                if (response == null)
                {
                    throw new ArgumentNullException("head", "Cannot be a null value");
                }

                // loop until we reach our index.
                while (true)
                {
                    // check if we are at the end of the linked list. 
                    if (current.Pointer == null)
                    {
                        // we have reached the end break out of our loop.
                        break;
                    }

                    // check if we reached our index passed.
                    if (currentIndex >= index)
                    {
                        // we set a new pointer to the next item and
                        // wait for fall off the end of the node list. 
                        response = (Nodes)response.Pointer;
                    }

                    // increment our index
                    currentIndex++;

                    // update our node pointer. 
                    current = (Nodes)current.Pointer;
                }

                return response;
            }
        }
    }
}
