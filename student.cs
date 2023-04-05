using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace รายวิชาที่เปิดสอน
{
    internal class student
    {
        private string subject { get; set; }
        private string NO { get; set; }

        public student(string subject, string nO)
        {
            this.subject = subject;
            NO = nO;
        }
        public string getSubject()
        {
            return subject;
        }
        public string getNo()
        {
            return NO;
        }
    }
}
