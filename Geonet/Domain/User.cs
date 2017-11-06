namespace Geonet.Domain
{
    public class User
    {
        #region Properties

        public Role[] Roles { get; set; }

        #endregion

        #region Constructor

        public User(Role[] roles)
        {
            Roles = roles;
        }

        #endregion
    }
}
