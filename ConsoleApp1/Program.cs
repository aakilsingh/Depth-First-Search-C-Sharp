using System.Collections;

namespace ConsoleApp1
{
    public class Program
    {
        public static void depthFirstPrint(Dictionary<string, List<string>> graph, string src)
        {
            // since we are doing a depth first search we use a stack, stack is of type string because it just stores our nodes
            Stack<string> stack = new Stack<string>();
            stack.Push(src);

            while (stack.Count != 0)
            {
                // gets current node
               string node = stack.Pop();
                Console.WriteLine(node);

                // gets the neighbours of current node and pushes them to a stack
                var neighbours = graph.GetValueOrDefault(node);
                foreach(var neighbour in neighbours)
                {
                    stack.Push(neighbour);
                }
            }
        }


        public static void Main(string[] args)
        {

            // key is the node
            // value is the list of neighbours of the node (list of other nodes)
            Dictionary<string,List<string>> graph = new Dictionary<string, List<string>> 
            {
                {"a",new List<string>{"c","b" } },
                {"b", new List<string>{"d"} },
                {"c",new List<string>{"e"} },
                {"d",new List<string>{} },
                {"e",new List<string>{} },
            };   

            depthFirstPrint(graph, "a");

            // gets the values for a specific node and prints them out
            //var list = graph.GetValueOrDefault("a");

            //foreach (var value in list) {
            //    Console.WriteLine(value);
            //}



            // check if the key and value has been added to dictionary
            //Console.WriteLine(graph.TryGetValue("f", out var list));

            //// print out all the values
            //foreach (KeyValuePair<string, List<string>> kvp in graph)
            //{
            //    foreach (string value in kvp.Value)
            //    {
            //        Console.WriteLine(value);
            //    }
            //}

        }
            
        }
    }
