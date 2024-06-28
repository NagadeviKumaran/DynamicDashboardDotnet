using System.ComponentModel.DataAnnotations;

namespace DynamicDashboard.Models
{
    public class ChartData
    {
        [Key]
        public int Id { get; set; }
        public List<string> Labels { get; set; }
        public List<DataSet> Datasets { get; set; }
    }

    
}
