using MiageCorp.AwesomeShop.Product.Models;

namespace MiageCorp.AwesomeShop.Product.Services
{
    public interface IProductService
    {
        void deleteProduct(string id);
        void updateProduct(string id, Produit produit);
        void addProduct(Produit product);
        Produit getProductById(string productId);
        List<Produit> getAllProducts();
    }
}
