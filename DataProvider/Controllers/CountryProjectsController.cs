using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataProvider.Infrastructure.Dto;
using DataProvider.Infrastructure.Entity;
using DataProvider.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DataProvider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CountryProjectsController : ControllerBase
    {
        private readonly IProjectsService _projectsService;

        public CountryProjectsController(IProjectsService projectsService)
        {
            _projectsService = projectsService;
        }

        [HttpPost]
        public ActionResult<List<Projects>> GetProjects(ProjectsRequestDto request)
        {
            if (request.CountryId <= 0)
            {
                throw new Exception("Country is empty");
            }
            return _projectsService.GetProjectListByCountryId(request.CountryId);
        }

    }
}