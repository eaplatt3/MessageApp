using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp
{
    public partial class Message
    {
        //Needs to be public becuse of access
        public enum PriorityEnum { HIGH, NORMAL, LOW };

        private string m_Body;
        private PriorityEnum m_Priority;

        public string Body { get; set; }

        public PriorityEnum Priority
        {
            get
            {
                return m_Priority;
            }

            set
            {
                m_Priority = value;
            }
        }
    }
}
