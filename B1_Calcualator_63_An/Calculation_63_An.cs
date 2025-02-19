using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_Calcualator_63_An
{
    public class Calculation_63_An
    {
        private int a_63_An, b_63_An;
        public Calculation_63_An(int a_63_An, int b_63_An)
        {
            this.a_63_An = a_63_An;
            this.b_63_An = b_63_An;
        }
        public int Execute_63_An(string CalSymbol_63_An)
        {
            int result_63_An = 0;
            switch (CalSymbol_63_An)
            {
                case "+":
                    result_63_An = this.a_63_An + this.b_63_An;
                    break;
                case "-":
                    result_63_An = this.a_63_An - this.b_63_An;
                    break;
                case "*":
                    result_63_An = this.a_63_An * this.b_63_An;
                    break;
                case "/":
                    result_63_An = this.a_63_An / this.b_63_An;
                    break;
            }
            return result_63_An;
        }
    }
}
