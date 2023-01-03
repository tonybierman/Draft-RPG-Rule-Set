using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftRpg.Skills
{
    public interface IDraftRpgSkill
    {
        RpgSkill Skill { get; }
        int Value { get; set; }
    }
}
