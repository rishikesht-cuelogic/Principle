using Principle.Models.ReadModels;
using System.Collections.Generic;

namespace Principle.Services.Entity
{
    public interface IEntityService
    {
        List<WildSearchModel> GetMasterBrands();
        List<WildSearchModel> GetNewBrands();

    }
}
