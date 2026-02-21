using InventoryManagement.Views; // Connects to the View

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {    
            InventoryView view = new InventoryView();
            view.Run();
        }
    }
