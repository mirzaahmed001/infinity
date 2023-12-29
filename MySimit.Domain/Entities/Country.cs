namespace MySimit.Domain.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string name_ar { get; set; }
        public string name_en { get; set; }
        public bool is_active { get; set; }
        public bool is_deleted { get; set; }
        public DateTime created_on { get; set; }
        public DateTime updated_on { get; set; }
    }
}
