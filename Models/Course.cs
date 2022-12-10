using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm_ps.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }   
    public string Level { get; set; }
    public virtual ICollection<Candidate> Candidates { get; set; }
}