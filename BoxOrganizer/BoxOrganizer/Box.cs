using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOrganizer
{
    class Box : IComparable
    {
        int priority;
        string[] items;
        int boxNumber;

        public Box(int priority, int boxNumber, string items)
        {
            this.priority = priority;
            this.boxNumber = boxNumber;
            this.items = items.Split(' ');
        }
        public int CompareTo(object obj)
        {
            Box otherBox = (Box)obj;
            return this.priority - otherBox.priority;
        }
        public bool ContainsItem(string wantedItem)
        {
            foreach(string item in items)
            {
                if (item == wantedItem)
                    return true;
            }
            return false;
        }
        public string toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.boxNumber + " ");
            sb.Append(this.priority + " ");
            sb.Append("Items[");
            foreach (string item in items)
            {
                sb.Append(item + " ");
            }
            sb.Append("]\n");
            return sb.ToString();
        }
    }
}
