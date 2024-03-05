namespace Server.Entities
{
    public enum Darga{ 
        one,
        two,
        three,
        four,
        five
    };
    public class Recepies
    {
        //קוד מתכון, שם מתכון, קוד קטגוריה, זמן הכנה בדקות, דרגת קושי 1-5
        //, תאריך הוספת המתכון לאתר, רשימת הרכיבים (אוסף מחרוזות), אופן ההכנה (אוסף מחרוזות), קוד משתמש שהכניס את המתכון, תמונה (מחרוזת של ניתוב).
        public int Id_Recipies { get; set; }
        public string Name { get; set; }
        public int Id_Category { get; set; }
        public int Time { get; set; }
        public Darga Darga { get; set; }
        public DateTime Date { get; set; }
        public List<string> Procces { get; set; }
        public List<string> Products { get; set; }
        public int Id_User { get; set; }
        public string ImgUrl { get; set; }

    }
}
