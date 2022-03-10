using MiageCorp.AwesomeShop.Product.Models;

namespace MiageCorp.AwesomeShop.Product.Services
{
    public class ProductService : IProductService
    {

        private static List<Produit> _products = new List<Produit>(){
            new Produit() { ProductId = Guid.NewGuid().ToString(), ProductLabel = "Produit 1", ProductDescription =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit", Price = 20d },
            new Produit() { ProductId = Guid.NewGuid().ToString(), ProductLabel = "Produit 2", ProductDescription =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit", Price = 12d },
            new Produit() { ProductId = Guid.NewGuid().ToString(), ProductLabel = "Produit 3", ProductDescription =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit", Price = 99.99d },
            new Produit() { ProductId = Guid.NewGuid().ToString(), ProductLabel = "Produit 4", ProductDescription =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit", Price = 5d },
            new Produit() { ProductId = Guid.NewGuid().ToString(), ProductLabel = "Produit 5", ProductDescription =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit", Price = 55.55d },
 };

        public void addProduct(Produit product)
        {
            
            if (_products.Any( p => p.ProductId == product.ProductId) || product.Equals(null) )
            {
                throw new NotImplementedException();
            }
            _products.Add(product);

        }

        public void deleteProduct(string id)
        {
            var produit = _products.SingleOrDefault(p => p.ProductId == id);
            if (produit != null)
            {
                _products.Remove(produit);
            }
           
        }

        public List<Produit> getAllProducts()
        {
            return _products.ToList();  
        }

        public Produit getProductById(string productId)
        {
            var produit = _products.SingleOrDefault(p => p.ProductId == productId);
            if (produit != null)
            {
                return produit;
            }
            throw new Exception();
        }

        public void updateProduct(string id, Produit produit)
        {
            var prod = _products.SingleOrDefault(p => p.ProductId == id);

            if(prod != null)
            {
                prod.ProductLabel = produit.ProductLabel;
                prod.ProductDescription = produit.ProductDescription;
                prod.Price  = produit.Price;
         
            }
            throw new Exception();
        }
    }

}
