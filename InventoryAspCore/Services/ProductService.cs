using Infrastructure.Interfaces;
using Inventory.Infrastructure.Models;
using InventoryAspCore.Models;

namespace Inventory.Mvc.Services
{
    public class ProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }
        internal List<ProductViewModel> GetAll()
        {
            var models= _repository.GetAll();
            var viewModels = Mapper(models);
            return viewModels.ToList();
        }

        private Product Mapper(ProductViewModel viewModel)
        {
            return new Product
            {
                Id = viewModel.Id,
                Name = viewModel.Description,
                Quantity = viewModel.Quantity
            };
        }

        private ProductViewModel Mapper(Product model)
        {
            return new ProductViewModel
            {
                Id = model.Id,
                Description = model.Name,
                Quantity = model.Quantity
            };
        }

        private IEnumerable<ProductViewModel> Mapper(IEnumerable<Product> models)
        {
            var result= new List<ProductViewModel>();

            foreach (var p in models)
            {
                result.Add(Mapper(p));
            }
            return result;
        }

        internal ProductViewModel Insert(ProductViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        internal void ValidateCreating(ProductViewModel viewModel, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState)
        {
            if (viewModel.Description.Contains("leche"))
                modelState.AddModelError("Description", "No puedes añadir leche");

        }
    }
}
