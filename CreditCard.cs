/*
 * Created by SharpDevelop.
 * User: edenfield-john
 * Date: 10/18/2016
 * Time: 10:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CodeEval
{
	/// <summary>
	/// Description of CreditCard.
	/// </summary>
	public class CreditCard
	{
		List<int> numlist = new List<int>();
		List<int> doublelist = new List<int>();
		public CreditCard(string line)
		{
			

        
            //int ccnum = 0;
            line = line.Replace(" ", "");
            for (int i = -2; i < line.Length-2;)
            {
                i =i + 2;
                doublelist.Add(Convert.ToInt16(line[i+1].ToString()));
                numlist.Add(Convert.ToInt16(line[i].ToString())*2);
                //Console.Write(Convert.ToInt16(line[i].ToString())*2);

                
            }
            Console.Write("\n");
            int x = 0, y=0;
            foreach (int num in numlist)
            {

                x += num;
                
            }
            
            foreach (int num in doublelist)
            {
            	y += num;
            }
            x = x+y;
            
            
            if(x%10 == 0)
            	Console.WriteLine("Real");
            else
            	Console.WriteLine("Fake");
 

		}
	}
}
