namespace BinarySearchtree
{
    class Program
    {
        public static void Main(string[] arg)
        {
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            Console.WriteLine("Inorder Traversal : ");
            binarySearch.Display();
            //Console.ReadLine();

        }
    }
}