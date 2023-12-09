using System.Text.Json.Serialization;

namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class SubscriptionPlan
    {
        public int SubscriptionPlanId { get; set; }
        public string? PlanName { get; set; }
        public string? PlanDescription { get; set; }
        public decimal PlanPrice { get; set; }
        public bool IsActive { get; set; }
       // [JsonIgnore]
        //public ICollection<ApplicationUser>? Users { get; set; }
    }
}
