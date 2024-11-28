using System.ComponentModel.DataAnnotations;

namespace TP3.Models
{
    public class Concert
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Artist { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public TimeSpan StartTime { get; set; }
        [Required]
        [StringLength(100)]
        public string Venue { get; set; }
        [Required]
        [Range(0, 1000)]
        public decimal TicketPrice { get; set; }
        [Required]
        [Range(0, 10000)]
        public int AvailableSeats { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string ArtistOrigin { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
