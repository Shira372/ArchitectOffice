namespace Clean.API.Models
{
    //המטרה שלי לספק לקליינט רק את מה שהוא חייב לראות
    //אני רוצה שכל אוביקט יעשה תפקיד אחר ואחד
    //ולכן ArchitectPostModel את מה שהקליינט יכול לשלוח-מגדיר למבני הנתונים   
    public class ArchitectPostModel
    {
        public string Name { get; set; }
        public int Status { get; set; }
        public int PlanId { get; set; }
    }   
}
//DTO-data transform object-יש לי את המודלים שמול הdb
//ויש לי מודלים שמטרתם להעביר נתונים לשכבות אחרות
