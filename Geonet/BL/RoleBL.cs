using Geonet.Domain;
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

        public void AddRole (Role roleToAdd)
        {
            roleDal.saveRole(roleToAdd);
        }

        public void DeleteRole(Role roleToDelete)
        {
            roleDal.DeleteRole(roleToDelete);
        }

        #endregion
    }
}
