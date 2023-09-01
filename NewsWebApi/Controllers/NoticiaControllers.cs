using NoticiasBusinessEntities.NoticiaEntitie;
using NoticiaServiceHost.Noticia;
using NoticiasService.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.UI.WebControls.WebParts;




namespace NoticiasWebApi.Controllers
{
    public class NoticiaControllers : ApiController
    {
        private readonly INoticiaServices noticiaServices;
       
        public NoticiaControllers(INoticiaServices noticiaServices)
        {
            this.noticiaServices = noticiaServices;

        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = noticiaServices.GetAllNoticias(new GetAllNoticiasMessageIn());

            if (result == null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult Post(NoticiaEntitie request)
        {
            var input = new InsertNoticiaMessageIn();

            request = input.NoticiaEntitie;

            var result = noticiaServices.InsertNoticia(input);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

       

    }    
}