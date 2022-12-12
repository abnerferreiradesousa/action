using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm_ps.Models
{
    public class CandidateCourse
    {
        public int CandidateId { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }
        public Candidate Candidate { get; set; }
    }
}