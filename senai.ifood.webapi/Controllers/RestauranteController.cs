using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using senai.ifood.domain.Contacts;
using senai.ifood.domain.Entities;

namespace senai.ifood.webapi.Controllers {
    [Route ("api/[controller]")]
    public class RestauranteController : Controller {
        private IBaseRepository<RestauranteDomain> _restauranteRepository;

        public RestauranteController (IBaseRepository<RestauranteDomain> restauranteRepository) {
            _restauranteRepository = restauranteRepository;
        }

        [HttpGet]
        [ProducesResponseType (typeof (List<RestauranteDomain>), 200)]
        [ProducesResponseType (typeof (string), 400)]
        public IActionResult GetAction () {
            //utilizar este método no ICollection
            return Ok (_restauranteRepository.Listar (new string[]{"ProdutoRestaurante"}) );
        }

        [HttpGet ("{id}")]
        public IActionResult GetAction (int id) {
            var restaurante = _restauranteRepository.BuscarPorId (id);
            if (restaurante != null)
                return Ok (restaurante);
            else
                return NotFound ();
        }

    }

}