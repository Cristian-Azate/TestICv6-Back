using NoticiasBusinessEntities.NoticiaEntitie;
using NoticiasService.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace NoticiasWebApi.Controllers
{
    public class NoticiasController : ApiController
    {
        private readonly INoticiaServices noticiaServices;

        public NoticiasController(INoticiaServices noticiaServices)
        {
            this.noticiaServices = noticiaServices;

        }

        public IHttpActionResult Get()
        {
            var result = noticiaServices.GetAllNoticias(new GetAllNoticiasMessageIn());

            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }


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
