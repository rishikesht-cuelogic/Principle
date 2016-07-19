using Principle.Models.Constants;
using Principle.Models.ReadModels;
using Principle.Services.Entity;
using Principle.Services.Recommendation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Principle.API.Controllers
{
    [RoutePrefix("api/recommendation")]
    public class RecommendationController : ApiController
    {
        #region Declaration(s)
        IEntityService entityService;
        IRecommendationService recommendationService;
        #endregion

        #region Properties
        #endregion

        #region Constructor(s)
        public RecommendationController()
        {
            entityService = new EntityService();
            recommendationService = new RecommendationService();
        }
        #endregion

        #region Method(s)
        [HttpPost]
        public HttpResponseMessage Fetch(List<WildSearchModel> collection)
        {
            try
            {
                var recommendations = recommendationService.GetRecommendation(collection);
                var successResponse =
                    Request.CreateResponse(HttpStatusCode.OK, recommendations, MediaTypeFormats.Json);

                return successResponse;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new ErrorModel
                {
                    ErrorKey = ErrorKeys.ServerError,
                    ErrorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message
                }, MediaTypeFormats.Json);
            }
        }
        #endregion

        #region Function(s)
        #endregion
    }
}
