using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23A_and_B
{
    class Checkbox
    {
        private bool? checkBoxStatus;
        private string description;

        public bool? CheckBoxStatus
        {
            get { return checkBoxStatus; }
            set
            {
                checkBoxStatus = value;
            }
        }
        public string Description
        {
            get
            {
                if (checkBoxStatus.HasValue)
                    description = (checkBoxStatus.Value ? "Checked" : "Unchecked");
                else
                {
                    description = "Unassigned";
                }
                return description;
            }
        }


    }
}
