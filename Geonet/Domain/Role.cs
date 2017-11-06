using Geonet.Enums;

namespace Geonet.Domain
{
    public class Role
    {
        #region Properties

        public Permissions[] Permissions { get; set; }
        public string Name { get; set; }

        #endregion

        #region Constructor

        public Role(Permissions[] permissions)
        {
            Permissions = permissions;
        }

        #endregion
    }
}
