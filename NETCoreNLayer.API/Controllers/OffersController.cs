using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NETCoreNLayer.API.Dto;
using NETCoreNLayer.Core.Models;
using NETCoreNLayer.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreNLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private readonly IOfferService _offerService;
        private readonly IMapper _mapper;
        public OffersController(IOfferService offerService, IMapper mapper)
        {
            _offerService = offerService;
            _mapper = mapper;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _offerService.GetByIdAsync(id);
            return Ok(_mapper.Map<OfferDto>(product));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var offers = await _offerService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<OfferDto>>(offers));
        }

        [HttpPost]
        public async Task<IActionResult> Save(OfferDto product)
        {
            var newOffer = await _offerService.AddAsync(_mapper.Map<Offer>(product));
            return Created(string.Empty, _mapper.Map<OfferDto>(newOffer));
        }

        [HttpPut]
        public IActionResult Update(OfferDto product)
        {
            _offerService.Update(_mapper.Map<Offer>(product));
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _offerService.GetByIdAsync(id).Result;
            _offerService.Remove(product);
            return NoContent();
        }

        [HttpGet("{id}/product")]
        public async Task<IActionResult> GetWithProductByIdAsync(int id)
        {
            var offer = await _offerService.GetWithProductByIdAsync(id);
            return Ok(_mapper.Map<OfferProductDto>(offer));
        }
    }
}
