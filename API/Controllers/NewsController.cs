using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Entities;
using AutoMapper;
using API.DTOs;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsRepository _repo;
        private readonly IMapper _mapper;
        public NewsController(INewsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<List<NewsDto>>> GetNews(NewsDto n)
        {

            var news = await _repo.GetNewsAsync(n);
            var newsDto = _mapper.Map<IEnumerable<NewsDto>>(news);

            return Ok(newsDto);
        }

    }
}
