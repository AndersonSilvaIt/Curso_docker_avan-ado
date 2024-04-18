using API_Postgres.Business.Interfaces.Repositorios;
using API_Postgres.Business.Models;
using API_Postgres.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API_Postgres.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(IMapper mapper, IPessoaRepository pessoaRepository)
        {
            _mapper = mapper;
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var list = await _pessoaRepository.ObterTodos();

            var map = _mapper.Map<IList<PessoaVM>>(list);

            return Ok(map);
        }

        [HttpPost]
        public async Task<IActionResult> Salvar(PessoaVM pessoaVM)
        {
            var teste = await _pessoaRepository.Salvar(_mapper.Map<Pessoa>(pessoaVM));
            pessoaVM.id = teste.Id;

            return Ok(pessoaVM);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> OberPorId(int id)
        {
            var entity = await _pessoaRepository.ObterPorId(id);

            return Ok(_mapper.Map<PessoaVM>(entity));
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(PessoaVM pessoaVM)
        {
            var update = await _pessoaRepository.Update(_mapper.Map<Pessoa>(pessoaVM));

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(int id)
        {
            return Ok(await _pessoaRepository.Remover(id));
        }
    }
}