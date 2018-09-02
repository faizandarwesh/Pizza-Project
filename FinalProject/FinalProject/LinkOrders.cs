using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject
{
    
    public class Node
    {
        public Node next;
        public string quantity;
        public string itemName;
        public double price;
        

    }

        class LinkOrders
        {
            static bool progressReport = false;
            public Node temp1 = null;
            static Node curr = null;
            static Node head = null;
            static Node current = null;


            public string Item_name()
            {

                return curr.itemName;
            }

            public string Quantity()
            {
                return curr.quantity;
            
            }

            public double Price()
            {
                
                return curr.price;
            
            }

            public void setHead()
            {
                curr = head;
            
            }

            public void ordernext()
            {

                curr = curr.next;
 
            
            }

            public bool getCheck() {
               
                if (curr.next == null)
                    return false;

                else return true;
            }


            public void AddToBill(string name,string quantity, double price){
            
                if(head == null){
                    head = new Node();
                    head.itemName = name;
                    head.quantity = quantity;
                    head.price = price * Convert.ToDouble(quantity);
                    head.next = null;

                    current = head;

                }
                else{
                    Node curr = new Node();
                    Node temp = head;
                   while(temp.next != null){
                        temp = temp.next;
                    }
                    curr.itemName = name;
                    curr.quantity = quantity;
                    curr.price = price * Convert.ToDouble(quantity);    
                    curr.next = null;
                    temp.next= curr;

                }
            }
            public void DeleteAllOrders()
            {
                head = null;
            }
            public bool OrderProgess()
            {
                    return progressReport;
                
            }
            public void OrderProgessSet(bool PR)
            {
                progressReport = PR;

            }
            public void Print(){
                Node current = head;
                while(current != null){
            System.Windows.Forms.MessageBox.Show(current.itemName + "   " + current.quantity + "   "  + current.price );
                    current = current.next;
                }

            


        }
    }

}
