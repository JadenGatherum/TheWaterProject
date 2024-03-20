using System.ComponentModel.DataAnnotations;

namespace TheWaterProject.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Programname { get; set; }
        public string? ProjectType { get; set; }
        public int ProjectImpact { get; set; }
        public DateTime ProjectInstallation { get; set; }
        public string ProjectPhase { get; set; }


    }
}
