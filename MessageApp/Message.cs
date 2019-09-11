using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace MessageApp
{
    public partial class Message
    {
        
        //Member Variables
        private string m_Title;
        private IPAddress m_Destination;
        private readonly int m_Version;

        public string Title { get; set; }
              
  
        public IPAddress Destination
        {
            get
            {
                return m_Destination;
            }

            set
            {
                m_Destination = value;
            }
        }

        public int Version
        {
            get
            {
                return m_Version;
            }
        }

        public Message() : this("empty", "empty", PriorityEnum.NORMAL, System.Net.IPAddress.Parse("172.0.0.1"))
        {
           
        }



        public Message(string title, string body, PriorityEnum priority, IPAddress destination, int version)
        {
            m_Version = 1;
            Title = title;
            Body = body;
            Priority = priority;
            Destination = destination;



        }

        public override bool Equals(object obj)
        {
            Message other = (Message)obj;

            if (Title.Equals(other.Title))
            {
                return true;
            }

            return false;
        }

    }
}
