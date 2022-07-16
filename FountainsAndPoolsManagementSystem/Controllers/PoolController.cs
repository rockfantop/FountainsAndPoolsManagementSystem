using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specification;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FountainsAndPoolsManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoolController : ControllerBase
    {
        private readonly IRepository<Pool> poolRepo;
        private readonly IRepository<Marker> markerRepo;
        private readonly IRepository<PoolConfiguration> configRepo;

        public PoolController(IRepository<Pool> poolRepo, IRepository<Marker> markerRepo, IRepository<PoolConfiguration> configRepo)
        {
            this.poolRepo = poolRepo;
            this.markerRepo = markerRepo;
            this.configRepo = configRepo;
        }

        [HttpGet]
        [Route("poolinfo")]
        public async Task<IActionResult> GetPoolInfo([FromQuery] Guid id)
        {
            var pool = await this.poolRepo.FindAsync(new Specification<Pool>(el => el.Id == id));

            return Ok(pool);
        }

        [HttpGet]
        [Route("markerinfo")]
        public async Task<IActionResult> GetMarkerInfo([FromQuery] Guid id)
        {
            var pool = await this.markerRepo.FindAsync(new Specification<Marker>(el => el.Id == id));

            return Ok(pool);
        }

        [HttpGet]
        [Route("getpoolwithconfig")]
        public async Task<IActionResult> GetPoolWithConfig([FromQuery] Guid id)
        {
            var pool = await this.poolRepo.FindAsync(new Specification<Pool>(el => el.Id == id));

            var config = await this.configRepo.FindAsync(new Specification<PoolConfiguration>(el => el.PoolId == id));

            pool.Configurations = new List<PoolConfiguration>();

            pool.Configurations.Add(config);

            return Ok(new { pool = pool, config = config });
        }

        [HttpPost]
        [Route("createpool")]
        public async Task<IActionResult> CreatePool([FromBody] Pool pool)
        {
            var result = "";

            try
            {
                pool.Id = Guid.NewGuid();

                await this.poolRepo.AddAsync(pool);

                await this.poolRepo.SaveChanges();

                result = "Success";
            }
            catch (Exception)
            {
                result = "Failed to create new pool";
            }

            return Ok(new { result = result, id = pool.Id });
        }

        [HttpPost]
        [Route("createmarker")]
        public async Task<IActionResult> CreateMarker([FromBody] Marker marker)
        {
            var result = "";

            try
            {
                marker.Id = Guid.NewGuid();

                await this.markerRepo.AddAsync(marker);

                await this.markerRepo.SaveChanges();

                result = "Success";
            }
            catch (Exception)
            {
                result = "Failed to create new pool";
            }

            return Ok(new { result = result, id = marker.Id });
        }

        [HttpPost]
        [Route("addconfig")]
        public async Task<IActionResult> AddConfig([FromBody] PoolConfiguration config)
        {
            var result = "";

            try
            {
                config.Id = Guid.NewGuid();

                await this.configRepo.AddAsync(config);

                await this.configRepo.SaveChanges();

                result = "Success";
            }
            catch (Exception)
            {
                result = "Failed to create new pool";
            }

            return Ok(new { result = result, id = config.Id });
        }
    }
}
