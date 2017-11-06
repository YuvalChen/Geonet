using Geonet.Domain;
using System.Collections.Generic;

namespace Geonet.DAL
{
    public class RoleDAL
    {
        #region DataMemebrs

        private List<Role> roles;

        #endregion

        #region Properties

        public List<Role> Roles { get => roles; set => roles = value; }

        #endregion

        #region Public Methods

        public List<Role> GetAllRoles()
        {
            return Roles;
        }

        public void SaveRole(Role newRole)
        {
            Roles.Add(newRole);
        }

        public void DeleteRole(Role roleToDelete)
        {
            Roles.Remove(roleToDelete);
        }

        #endregion
    }
}
