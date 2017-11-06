using Geonet.Domain;
using System.Collections.Generic;
using RoleDal=Geonet.DAL.RoleDAL;

namespace Geonet.BL
{
    public class RoleBL
    {
        #region DataMembers

        private RoleDal roleDal;

        #endregion

        #region Constructor

        public RoleBL()
        {
            roleDal = new RoleDal();
        }

        #endregion

        #region Public Methods

        public List<Role> GetAllRoles()
        {
            return roleDal.GetAllRoles();
        }

        public void AddRole (Role roleToAdd)
        {
            roleDal.SaveRole(roleToAdd);
        }

        public void DeleteRole(Role roleToDelete)
        {
            roleDal.DeleteRole(roleToDelete);
        }

        #endregion
    }
}
