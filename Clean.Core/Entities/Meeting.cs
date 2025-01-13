namespace ArchitectsOffice.Entities
{
    public class Meeting
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Meeting(int id, DateTime start, DateTime end)
        {
            Id = id;
            Start = start;
            End = end;
        }
    }
}
