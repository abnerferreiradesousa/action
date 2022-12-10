using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm_ps.Models;

public class Candidate
{
    public int Id { get; set; }
    public string Name { get; set; }   
    public string CPF { get; set; }
    public virtual ICollection<Course> Courses { get; set; }
}