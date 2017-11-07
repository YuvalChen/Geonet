using Microsoft.AspNetCore.Mvc;
using Geonet.BL;

namespace Geonet.Controllers
{
    [Route("Roles")]
    public class RoleController : Controller
    {
        #region DataMembers

        private RoleBL roleBl;

        #endregion

        #region Constructor

        public RoleController ()
        {
            roleBl = new RoleBL();
        }

        #endregion

        [HttpGet]
        public int Get()
        {
            return 0;
            //var allRoles = roleBl.GetAllRoles();
            //return allRoles.Count;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
