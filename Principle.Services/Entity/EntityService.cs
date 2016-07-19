using System;
using System.Collections.Generic;
using Principle.Models.ReadModels;
using Principle.Repository;

namespace Principle.Services.Entity
{
    public class EntityService : IEntityService
    {

        #region Declaration(s)
        private readonly EntityRepository repository;
        #endregion

        #region Properties
        public EntityService()
        {
            repository = new EntityRepository();
        }
        #endregion

        #region Constructor(s)
        #endregion

        #region Method(s)
        public List<WildSearchModel> GetMasterBrands()
        {
            return repository.MasterBrands;
        }

        public List<WildSearchModel> GetNewBrands()
        {
            return repository.NewBrands;
        }
        #endregion

        #region Function(s)
        #endregion

    }
}
