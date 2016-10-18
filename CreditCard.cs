class CreditCardReal
    {
        static List<int> numlist = new List<int>();
        public CreditCardReal(string line)

        {
            //int ccnum = 0;
            line = line.Replace(" ", "");
            for (int i = -2; i < line.Length-2;)
            {
                i =i + 2;
                numlist.Add(Convert.ToInt16(line[i].ToString()));
                Console.Write(Convert.ToInt16(line[i].ToString())*2);

                
            }
            Console.Write("\n");
            int x = 0;
            foreach (int num in numlist)
            {

                x += num;
                
            }
            Console.WriteLine(x);
        }
    }
