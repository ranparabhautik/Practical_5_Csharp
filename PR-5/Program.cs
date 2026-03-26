class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 10, 50, 60, 30, 80 };

        try
        {
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine($"{i} -> {arr[i]}");
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally Block Executed");
        }
    }
}