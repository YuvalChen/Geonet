using Geonet.Domain;
using System.Collections.Generic;

namespace Geonet.DAL
{
    public class RoleDAL
    {
        #region DataMemebrs

        private List<Role> roles;

        #endregion

        #region Public Methods

        public void saveRole(Role newRole)
        {
            roles.Add(newRole);
        }

        public void DeleteRole(Role roleToDelete)
        {
            roles.Remove(roleToDelete);
        } 

        #endregion
    }
}
