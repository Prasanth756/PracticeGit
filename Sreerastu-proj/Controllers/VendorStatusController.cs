using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sreerastu_proj.Models;
using Sreerastu_proj.Repository;
using System.IO;
using System.Net;

namespace Sreerastu_proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorStatusController : ControllerBase
    {
        IPostRepository PostRepository; 
        public VendorStatusController (IPostRepository _postRepository)
        {
            PostRepository = _postRepository;
        }
        [HttpGet]
        [Route("GetVendorStatus")]
        public async Task<IActionResult> GetVendorStatus()
        {
            try
            {
                var VendorStatus = await PostRepository.GetVendorStatus();
                if (VendorStatus == null)
                {
                    return NotFound();
                }
                return Ok(VendorStatus);
            }
            catch (WebException ex)
            {
                // return BadRequest();
                string message = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                return BadRequest();
            }
            //return Ok;

        }
        [HttpGet]
        [Route("GetVendorStatusID")]
        public async Task<IActionResult> GetVendorStatusID(int? ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }

            try
            {
                var VendorStatus = await PostRepository.GetVendorStatusID(ID);

                if (VendorStatus == null)
                {
                    return NotFound();
                }

                return Ok(VendorStatus);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("AddVendorStatus")]
        public async Task<IActionResult> AddVendorStatus([FromBody] TblVendorStatus model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var VendorStatus = await PostRepository.AddVendorStatus(model);
                    if (VendorStatus != null)
                    {
                        return Ok(VendorStatus);
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
        [Route("UpdateVendorStatus")]
        public async Task<IActionResult> UpdateVendorStatus([FromBody] TblVendorStatus model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await PostRepository.UpdateVendorStatus(model);

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
        [Route("DeleteVendorStatus")]
        public async Task<IActionResult> DeleteVendorStatus(int? ID)
        {
            int result = 0;
            if (ID == null)
            {
                return BadRequest();
            }
            try
            {
                result = await PostRepository.DeleteVendorStatus(ID);
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
