namespace TimeSheet.Domain.Entities
{
    public class TimeSheet 
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }

        // Ajout des propriétés pour la période de temps
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
