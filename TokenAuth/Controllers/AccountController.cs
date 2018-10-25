using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TokenAuth.Models;

namespace TokenAuth.Controllers
{
    [Authorize]
    public class AccountController : ApiController
    {
        [HttpGet]
        [Route("api/account/getuser/{id}")]
        public IHttpActionResult GetUFirstUser(int id)
        {
            // Get user from dummy list

           var userList = new List<User>(){
                  new User() {
                    Id = 1,
                    Name ="Zulqarnain",
                    Email = "z@g.com",
                    Password="test"
                },
                new User() {
                    Id = 2,
                    Name ="twt",
                    Email = "t@g.com",
                    Password="test"
                }
            };

            var user = userList.FirstOrDefault(x => x.Id == id);
            return Ok(user);
        }
    }
}