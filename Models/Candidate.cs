using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace crm_ps.Models;

public class Candidate
{
    public int Id { get; set; }
    public string Name { get; set; }   
    public string CPF { get; set; }
    public ICollection<CandidateCourse> CandidateCourses { get; set; }

    public Candidate()
    {
        CandidateCourses = new Collection<CandidateCourse>();
    }
}