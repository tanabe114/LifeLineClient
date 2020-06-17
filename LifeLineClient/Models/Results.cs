using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLineClient.Models
{
    public class IndexResult
    {
        public string group_Id { get; set; }
        
        public string group_Name { get; set; }

        public int group_Count { get; set; }
    }

    public class Member
    {
        public string status { get; set; }

        public string img_Url { get; set; }

        public string name { get; set; }

        public string comment { get; set; }

        public string location_Title { get; set; }

        public string location_Address { get; set; }

        public DateTime? created_At { get; set; }
    }

    public class DetailsResult
    {
        public string group_Name { get; set; }

        public int group_Count { get; set; }

        public int group_Safely { get; set; }

        public int group_Injured { get; set; }

        public List<Member> liffMemberSafeties { get; set; }
    }
}
