using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Linq;

namespace MMABooksBusinessClasses
{
    public class Product
    { 
        public Product() { }

        public Product(string productCode, string description, decimal unitPrice, int onHandQuantity)
        {
            ProductCode = productCode;
            Description = description;
            UnitPrice = unitPrice;
            OnHandQuantity = onHandQuantity;
        }

        //instance variables 

        private string productCode;
        private string description;
        private decimal unitPrice;
        private int onHandQuantity;

        public string ProductCode
        {
            get
            {
                return productCode;
            }

            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length <= 4)
                    productCode = value;
                else
                    throw new ArgumentOutOfRangeException("Product Code must be 4 characters.");
            }

        }
          
        public string Description 
        { 
            get
            {
                return description;
            }

            set
            {
                if (value.Trim().Length > 10 && value.Trim().Length <= 100)
                    description = value;
                else
                    throw new ArgumentOutOfRangeException("Descritption must be between 10 and 100 characters.");
            }

        
        
        }
        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if (value > 0 && value <= 9999.9999m)
                    unitPrice = value;
                else
                    throw new ArgumentOutOfRangeException("Unit Price has to be greater than 0.");
            }
        }
        public int OnHandQuantity 
        {
            get
            {
                return onHandQuantity;
            }
            set
            {
                if (value >= 0 && value <= 9999)
                    onHandQuantity = value;
                else
                    throw new ArgumentOutOfRangeException("On Hand Quantity has to be between 0 and 9999.");
            }
        }
    }
}
