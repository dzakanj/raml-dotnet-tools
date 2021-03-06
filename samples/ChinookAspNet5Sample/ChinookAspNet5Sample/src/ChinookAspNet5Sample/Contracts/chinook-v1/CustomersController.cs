// Template: Base Controller (ApiControllerBase.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ChinookAspNet5Sample.ChinookV1.Models;

// Do not modify this file. This code was generated by RAML Web Api 2 Scaffolder

namespace ChinookAspNet5Sample.ChinookV1
{
    [Route("customers")]
    public partial class CustomersController : Controller
    {


		/// <returns>IList&lt;Customer&gt;</returns>
        [HttpGet]
        [Route("")]
        public virtual IActionResult GetBase()
        {
            // Do not modify this code
            return  ((ICustomersController)this).Get();
        }

		/// <param name="content"></param>
        [HttpPost]
        [Route("")]
        public virtual IActionResult PostBase([FromBody] Models.Customer content)
        {
            // Do not modify this code
            return  ((ICustomersController)this).Post(content);
        }

		/// <param name="id"></param>
		/// <returns>Customer</returns>
        [HttpGet]
        [Route("{id}")]
        public virtual IActionResult GetByIdBase(string id)
        {
            // Do not modify this code
            return  ((ICustomersController)this).GetById(id);
        }

		/// <param name="content"></param>
		/// <param name="id"></param>
        [HttpPut]
        [Route("{id}")]
        public virtual IActionResult PutBase([FromBody] Models.Customer content,string id)
        {
            // Do not modify this code
            return  ((ICustomersController)this).Put(content,id);
        }

		/// <param name="id"></param>
        [HttpDelete]
        [Route("{id}")]
        public virtual IActionResult DeleteBase(string id)
        {
            // Do not modify this code
            return  ((ICustomersController)this).Delete(id);
        }
    }
}
