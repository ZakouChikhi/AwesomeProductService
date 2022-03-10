using MiageCorp.AwesomeShop.Product.Models;

namespace MiageCorp.AwesomeShop.Product.Services
{
    public interface IProductService
    {
        void deleteProduct(int id);
        void updateProduct(int id, Produit produit);
        void addProduct(Produit product);
        Produit getProductById(int productId);
        List<Produit> getAllProducts();
    }
}
