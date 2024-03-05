namespace Server.Entities
{
    public class User
    {
        //קוד, שם, כתובת , מייל, סיסמא
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
