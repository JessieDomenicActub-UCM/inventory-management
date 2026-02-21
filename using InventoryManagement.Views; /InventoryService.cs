using System;

namespace InventoryManagement.Services
{
    public class InventoryService
{
 
        private string[,] products = new string[2, 3] 
        {
            { "Apples", "Milk", "Bread" },
            { " 10", "   5", "  20" }
        };


        private string[] initialStock = { "  10", "   5", "  20" };

        public string[,] GetInventory()
        {
            return products;
        }

        public void UpdateStock(int productIndex, string newQuantity)
        {
            if (productIndex >= 0 && productIndex < products.GetLength(1))
            {
                products[1, productIndex] = newQuantity;
            }
        }

        public void ResetInventory()
        {
            for (int i = 0; i < initialStock.Length; i++)
            {
                products[1, i] = initialStock[i];
            }
        }
    }
}
