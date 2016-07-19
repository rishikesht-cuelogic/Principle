using Principle.Models.ReadModels;
using System.Collections.Generic;

namespace Principle.Services.Recommendation
{
    public interface IRecommendationService
    {
        List<RecommendationModel> GetRecommendation(List<WildSearchModel> collection);
    }
}
