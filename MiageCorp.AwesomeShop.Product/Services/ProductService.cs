using MiageCorp.AwesomeShop.Product.Models;

namespace MiageCorp.AwesomeShop.Product.Services
{
    public class ProductService : IProductService
    {

        private static List<Produit> _products = new List<Produit>();
        public void addProduct(Produit product)
        {
            
            if (_products.Any( p => p.ProductId == product.ProductId) || product.Equals(null) )
            {
                throw new NotImplementedException();
            }
            _products.Add(product);

        }

        public void deleteProduct(int id)
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

        public Produit getProductById(int productId)
        {
            var produit = _products.SingleOrDefault(p => p.ProductId == productId);
            if (produit != null)
            {
                return produit;
            }
            throw new Exception();
        }

        public void updateProduct(int id, Produit produit)
        {
            var prod = _products.SingleOrDefault(p => p.ProductId == id);

            if(prod != null)
            {
                prod.ProductName = produit.ProductName;
                prod.Quantity  = produit.Quantity;
         
            }
            throw new Exception();
        }
    }

}
