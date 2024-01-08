using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStartProject
{
    public class calculatorClass
    {
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private string op;

        public decimal CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

        public decimal Operand1
        {
            get { return operand1; }
            set { operand1 = value; }
        }

        public decimal Operand2
        {
            get { return operand2; }
            set { operand2 = value; }
        }

        public string Op
        {
            get { return op; }
            set { op = value; }
        }

        public calculatorClass()
        {
            this.currentValue = 0;
            this.operand1 = 0;
            this.operand2 = 0;
            this.op = null;
        }

        public decimal Add(decimal Operand1)
        {
            return currentValue = (operand1) + (operand2);
            op = "+";
        }

        public decimal Subtract(decimal Operand1)
        {
            return currentValue = (operand1) - (operand2);
            op = "-";
        }

        public decimal Multiply(decimal Operand1) 
        {
            return currentValue = (operand1) * (operand2);
            op = "*";
        }

        public decimal Divide(decimal Operand1) 
        {
            return currentValue = (operand1) / (operand2);
            op = "/";
        }

        public void Clear() 
        {
            this.currentValue = 0;
            this.operand1 = 0;
            this.operand2 = 0;
            this.op = null;
        }
    }
}
