using System;
using System.Collections.Generic;
using System.Text;

namespace FormDangKyHocVien
{
    internal class Course
    {
        public string DisplayMember { get; set; }
        public string ValueMember { get; set; }

        public Course(string displayMember, string valueMember)
        {
            DisplayMember = displayMember;
            ValueMember = valueMember;
        }
    }
}
