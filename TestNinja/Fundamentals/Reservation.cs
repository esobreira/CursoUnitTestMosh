namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            #region "change 1"
            // if (user.IsAdmin)
            //     return true;

            // if (MadeBy == user)
            //     return true;

            //return false;
            #endregion

            #region "change 2"

            // if (user.IsAdmin || MadeBy == user)
            //     return true;

            // return false;

            #endregion

            #region "change 3"

            return (user.IsAdmin || MadeBy == user);

            #endregion
        }

    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}