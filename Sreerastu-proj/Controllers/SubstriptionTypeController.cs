using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sreerastu_proj.Models;
using Sreerastu_proj.Repository;

namespace Sreerastu_proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubstriptionTypeController : ControllerBase
    {
        IPostRepository PostRepository;
        public SubstriptionTypeController(IPostRepository _postRepository)
        {
            PostRepository = _postRepository;
        }
        [HttpGet]
        [Route("GetSubscriptionType")]
        public async Task<IActionResult> GetSubscriptionType()
        {
            try
            {
                var SubscriptionType = await PostRepository.GetSubscriptionType();
                if (SubscriptionType == null)
                {
                    return NotFound();
                }
                return Ok(SubscriptionType);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        [HttpGet]
        [Route("GetSubscriptionTypes")]
        public async Task<IActionResult> GetSubscriptionTypes(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            try
            {
                var SubscriptionTypes = await PostRepository.GetSubscriptionTypes(id);

                if (SubscriptionTypes == null)
                {
                    return NotFound();
                }

                return Ok(SubscriptionTypes);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("AddSubscriptionType")]
        public async Task<IActionResult> AddSubscriptionType([FromBody] TblSubscriptionType model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var SubscriptionType = await PostRepository.AddSubscriptionType(model);
                    if (SubscriptionType != null)
                    {
                        return Ok(SubscriptionType);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }
        [HttpPost]
        [Route("UpdateSubscriptionType")]
        public async Task<IActionResult> UpdateSubscriptionType([FromBody] TblSubscriptionType model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await PostRepository.UpdateSubscriptionType(model);

                    return Ok(model);
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }
                    return BadRequest();
                }
            }
            return BadRequest();
        }
        [HttpPost]
        [Route("DeleteSubscriptionType")]
        public async Task<IActionResult> DeleteSubscriptionType(int? ID)
        {
            int result = 0;

            if (ID == null)
            {
                return BadRequest();
            }

            try
            {
                result = await PostRepository.DeleteSubscriptionType(ID);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}



    
