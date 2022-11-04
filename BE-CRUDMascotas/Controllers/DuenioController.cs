using AutoMapper;
using BE_CRUDMascotas.Models.DTO;
using BE_CRUDMascotas.Models.Entities;
using BE_CRUDMascotas.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BE_CRUDMascotas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuenioController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDuenioRepository _duenioRepository;

        public DuenioController(IMapper mapper, IDuenioRepository duenioRepository)
        {
            _mapper = mapper;
            _duenioRepository = duenioRepository;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, DuenioDTO duenioDto)
        {
            try
            {
                var duenioModificado = _mapper.Map<Duenio>(duenioDto);

                if (id != duenioModificado.Id)
                {
                    return BadRequest();
                }

                Duenio? duenioBaseDeDatos = _duenioRepository.GetDuenio(id);

                if (duenioBaseDeDatos == null)
                {
                    return NotFound();
                }

                _mapper.Map(duenioModificado, duenioBaseDeDatos);

                _duenioRepository.UpdateDuenio(duenioBaseDeDatos);

                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
