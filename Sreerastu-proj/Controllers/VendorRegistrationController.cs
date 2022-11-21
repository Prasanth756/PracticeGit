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
    public class VendorRegistrationController : ControllerBase
    {

        IPostRepository postRepository;
        public VendorRegistrationController(IPostRepository _postRepository)
        {
            postRepository = _postRepository;
        }
        [HttpGet]
        [Route("GetVendor")]
        public async Task<IActionResult> GetVendor()
        {
            try
            {
                var item = await postRepository.GetVendor();
                if (item != null)
                {
                    return Ok(item);

                }
                return NotFound();

            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("GetVendorByID")]
        public async Task<IActionResult> GetVendorByID(int vendorID)
        {

            try
            {
                var item = await postRepository.GetVendorByID(vendorID);
                if (item == null)
                {
                    return NotFound();
                }
                return Ok(item);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("AddVendor")]
        public async Task<IActionResult> AddVendor([FromBody] TblVendorRegistration tblVendorRegistration)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var item = await postRepository.AddVendor(tblVendorRegistration);
                    if (item != null)
                    {
                        return Ok(item);
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
        [Route("UpdateVendor")]
        public async Task<IActionResult> UpdateVendor([FromBody] TblVendorRegistration tblVendorRegistration)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await postRepository.UpdateVendor(tblVendorRegistration);
                    return Ok(tblVendorRegistration);
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


    }
}
