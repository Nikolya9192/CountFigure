using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountFigure
{
    public class Poisk
    {
        public List<Data> list = new List<Data>(0);
        public int[,] matrix;
        public int n = 0;
        public bool b = false;
        Data data = new Data();
        Go go = new Go();
      
        
        public Poisk(int[,] matrix)
        {
            this.matrix = matrix;
            
           
        }
        
        
        public int CountFigure()
        {
            int x = go.X;
            int y = go.Y;
            int result = 0;
            //проходження по елементах масива
            for (int i = 0; i < go.X; i++)
            {
                for (int j = 0; j < go.Y; j++)
                {
                    result = 0;
                    result = Start(i, j);
                    if (result == 1)
                        n += result; //підрахунок кількості фігур
                                     
                }
               
            }
            return n;
        }


        // рекурсія проходження по умовах в пошуках "1", та запам"ятовування індекса елемента в Список List,
        // з подальшою перевіркою на наявність в списку методом (Check()), для відсіювання повторних індексів 
        // які вже є у списку
        public int Start(int i, int j)
        {
            int m = 0;
            
            try
            {
                if (matrix[i, j] == 1 && Check(i, j) == false)
                {                   
                    m = 1;
                   
                   
                    if (i > -1 && j + 1 > -1 && i < go.X && j + 1 < go.Y)
                    {
                        if (matrix[i, j + 1] == 1)
                        Start(i, j + 1);
                    }
                    if (i + 1 > -1 && j + 1 > -1 && i + 1 < go.X && j + 1 < go.Y)
                    {
                        if (matrix[i + 1, j + 1] == 1)
                        Start(i + 1, j + 1);
                    }
                    if (i + 1 > -1 && j > -1 && i + 1 < go.X && j < go.Y)
                    {
                        if (matrix[i + 1, j] == 1)
                        Start(i + 1, j);
                    }
                    if (i + 1 > -1 && j - 1 > -1 && i + 1 < go.X && j - 1 < go.Y)
                    {
                        if (matrix[i + 1, j - 1] == 1)
                        Start(i + 1, j - 1);
                    }
                    if (i > -1 && j - 1 > -1 && i < go.X && j - 1 < go.Y)
                    {
                        if (matrix[i, j - 1] == 1)
                        Start(i, j - 1);
                    }
                    if (i - 1 > -1 && j - 1 > -1 && i - 1 < go.X && j - 1 < go.Y)
                    {
                        if (matrix[i - 1, j - 1] == 1)
                            Start(i - 1, j - 1);
                    }
                    if (i - 1 > -1 && j > -1 && i - 1 < go.X && j < go.Y)
                    {
                        if (matrix[i - 1, j] == 1)
                            Start(i - 1, j);
                    }
                    if (i - 1 > -1 && j + 1 > -1 && i - 1 < go.X && j + 1 < go.Y)
                    {
                        if (matrix[i - 1, j + 1] == 1)
                            Start(i - 1, j + 1);
                    }
                                                        
                }        
            }
            catch    
            {
               
            }
                       
            return m;
        }


        // перевірка на наявність індексів у списку
        public bool Check(int i, int j)
        {
            bool b = false;
            if (list.Count == 0)
            {
                list.Add(new Data(i, j));                
            }
            else
            {
                foreach (Data li in list)
                {
                    if (i == li.X && j == li.Y)
                    {
                        b = true;
                        return b;
                    }
                    else
                        b = false;

                }
                if (b == false)
                    list.Add(new Data(i, j));
            }
            return b;
        }
    }
}
