using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class SubscriptionUser
    {
        [Key]
        public int SubscriptonUserId { get; set; }

        public string? ApplicationUserId { get; set; }
       // [JsonIgnore]
       // public ApplicationUser? ApplicationUser { get; set; }


        public int SubscriptionPlanId { get; set; }
        //[JsonIgnore]
        //public SubscriptionPlan? SubscriptionPlan { get; set; }
        public string? TransactionId { get; set; }
        public bool? Accepted { get; set; }

    }
}
