using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
 class Program
 {
	    static void Main(string[] args)
		{
			LinkedList list = new LinkedList();
			list.Add(56);
			// list.Add(30);
			list.Add(70);
			list.Display();
			list.InsertAtParticularPosition(2,30);
		}
  }
}
