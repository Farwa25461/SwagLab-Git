using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testframework
{
    public class ProductPage:BasePage
    {
        By addproduct1 = By.CssSelector("#inventory_container > div > div:nth-child(1) > div.pricebar > button");
        By addproduct2 = By.CssSelector("#inventory_container > div > div:nth-child(2) > div.pricebar > button");
        By addproduct3 = By.CssSelector("#inventory_container > div > div:nth-child(3) > div.pricebar > button");
        By addproduct4 = By.CssSelector("#inventory_container > div > div:nth-child(4) > div.pricebar > button");

        public void Selectproducts()
        {
            click(addproduct1);
            click(addproduct2);
            click(addproduct3);
            click(addproduct4);
        }
        


    }
}
