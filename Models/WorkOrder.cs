
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiancasBikes.Models;

public class WorkOrder
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Please describe the problem with the bike")]
    [StringLength(100, ErrorMessage = "Work order descriptions must be 100 characters or less")]
    public string Description { get; set; }
    public DateTime DateInitiated { get; set; }
    public DateTime? DateCompleted { get; set; }

    public int? MechanicUserProfileId { get; set; }
    [ForeignKey("MechanicUserProfileId")]
    public UserProfile MechanicUserProfile { get; set; }

    public int InitiatedByUserProfileId { get; set; }
    [ForeignKey("InitiatedByUserProfileId")]
    public UserProfile InitiatedByUserProfile { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Please choose a bike")]
    public int BikeId { get; set; }
    public Bike Bike { get; set; }
}

