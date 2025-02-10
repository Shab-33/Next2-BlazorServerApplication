namespace Next2_BlazorServerApplication.Data
{
    public class AppDBContext
    {
        private static List<User> users = new List<User>();
        public static bool SaveUser(User user)
        {
            bool isExist = users.Any(x => x.Email == user.Email);
            if (!isExist)
            {
                users.Add(user);
                return true;
            } 
            return false;
        }
    }

    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
