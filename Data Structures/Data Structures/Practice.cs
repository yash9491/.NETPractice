using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class Practice
    {
        Node start;
        public Practice()
        {
            start = null;
        }
        public void InsertAtEnd(int data)
        {
            if(start == null){
                Node temp = new Node(data);
                start = temp;
            }

            Node p;
            p = start;

            while(p.link != null)
            {
                p = p.link;
            }

            Node temp1 = new Node(data);
            p.link = temp1;
        }
    }
}
