using CodeGroup.DesafioTecnico.Api.Domain.Constants;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CodeGroup.DesafioTecnico.Api.Controllers
{
    [ApiController]
    [ApiVersion(OtherContants.API_VERSION_1)]
    [Route(OtherContants.ROUTE_DEFAULT_CONTROLLER)]
    public class ProjectController : CodeGroupBaseController
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //var result = await _formalizeService.GetAll();

            //if (result.HasError)
            //    return StatusCode(HttpStatusCode.BadRequest, result.Notifications);

            //if (result.HasData)
            //    return StatusCode((int)HttpStatusCode.OK, result.DataObject, result.Notifications);

            //return StatusCode(HttpStatusCode.NotFound, result.Notifications);

            return  await Task.FromResult( StatusCode((int)HttpStatusCode.OK, null));
        }
    }
}
