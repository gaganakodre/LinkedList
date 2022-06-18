namespace LinkedList
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Linkedlist linked = new Linkedlist();
            Node node1 = new Node(70);
            Node node2 = new Node(56);
            Node node3 = new Node(30);
            linked.AddNode(node1);
            //linked.AddNode(node2);
            //linked.AddNode(node3);
            linked.Display();


        }
    }
}