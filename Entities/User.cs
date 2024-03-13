namespace Server.Entities
{
    public class User
    {
        //קוד, שם, כתובת , מייל, סיסמא
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
