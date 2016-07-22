using System;
using System.Collections.Generic;
using Principle.Repository;
using Principle.Models.ReadModels;
using System.Linq;

namespace Principle.Services.Recommendation
{
    public class RecommendationService : IRecommendationService
    {
        #region Declaration(s)
        private readonly EntityRepository repository;
        #endregion

        #region Properties
        #endregion

        #region Constructor(s)
        public RecommendationService()
        {
            repository = new EntityRepository();
        }
        #endregion

        #region Method(s)
        public List<RecommendationModel> GetRecommendation(List<WildSearchModel> collection)
        {
            var masterEntities = repository.MasterBrands;

            var suggestions = (from masterentity in masterEntities
                               from newentity in collection
                               where Common.Utilities.StringComparer.SpecialContains(masterentity.Name, newentity.Name)
                               select new
                               {
                                   EntityId = newentity.Id,
                                   Entity = newentity.Name,
                                   SuggestedEntity = masterentity.Name
                               }).Distinct();

            var recommendations = (from suggestion in suggestions
                                   group suggestion by new
                                   {
                                       suggestion.EntityId,
                                       suggestion.Entity
                                   } into groupsuggestion
                                   select new RecommendationModel
                                   {
                                       Id = groupsuggestion.Key.EntityId,
                                       Name = groupsuggestion.Key.Entity,
                                       Suggestions = string.Join(",", groupsuggestion.Select(x => x.SuggestedEntity))
                                   }).ToList();

            var allEntities = collection.Select(x => x.Name);
            var matchEntities = recommendations.Select(x => x.Name);

            var diff = allEntities.Except(matchEntities);
            var motion = diff.Select(x => new RecommendationModel { Name = x });

            recommendations.AddRange(motion);

            return recommendations;
        }
        #endregion

        #region Function(s)
        #endregion
    }
}
