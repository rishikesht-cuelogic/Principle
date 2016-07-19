using Principle.Models.Constants;
using Principle.Models.ReadModels;
using Principle.Services.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Principle.API.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        #region Declaration(s)
        IEntityService entityService;
        #endregion

        #region Properties
        #endregion

        #region Constructor(s)
        public HomeController()
        {
            entityService = new EntityService();
        }
        #endregion

        #region Method(s)
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Get()
        {
            try
            {
                var collection = entityService.GetNewBrands();
                var successResponse =
                    this.Request.CreateResponse<List<WildSearchModel>>(HttpStatusCode.OK, collection, MediaTypeFormats.Json);

                return successResponse;
            }
            catch (Exception ex)
            {
                return this.Request.CreateResponse<ErrorModel>(HttpStatusCode.InternalServerError, new ErrorModel
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
