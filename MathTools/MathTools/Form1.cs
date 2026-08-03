using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        delegate int Counting(int StartNum, int EndNum);
        private ArrayList PowerSet(int NullValue, params int[] array)
        {
            ArrayList list = new ArrayList();
            int[] Counter = new int[array.Length], temp;
            for (int i = 0; i < array.Length; i++) Counter[i] = i - 1;
            for (int i = 0; i < array.Length; i++)
            {
                temp = new int[i + 1];
                for (int j = 0; j < Combination(array.Length, i + 1); j++)
                {
                    if ((((j + 1) % array.Length) == 1) && (j != 0)) 
                        for (int r = 1; r < Counter.Length; r++)Counter[r] = (Counter[r] <= (array.Length - 2)) ? Counter[r] += 1 : 0;
                    for (int r = 0; r < Counter.Length; r++) Counter[r] = (Counter[r] <= (array.Length - 2)) ? Counter[r] +=1 : 0;
                    for (int n = 0; n < temp.Length; n++) temp[n] = array[Counter[n]];
                    list.Add(temp);
                }
            }
            return list;
        }
        private int Combination(int n, int r)
        {
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }

        private int Factorial(int n)
        {
            n = n == 0 ? 1 : n;
            for (int i = n - 1; i > 0; i--) n *= i;
            return n;
        }
    }
}
