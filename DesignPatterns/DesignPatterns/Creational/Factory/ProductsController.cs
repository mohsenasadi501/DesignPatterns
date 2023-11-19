namespace DesignPatterns.Creational.Factory
{
    internal class ProductsController : SharpController
    {
        public void ListProducts()
        {
            //get proccuts from the database
            Dictionary<string,object> context = new Dictionary<string,object>();
            Render("product.html", context);
        }
    }
}
