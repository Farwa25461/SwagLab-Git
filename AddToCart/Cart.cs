using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testframework
{
    public class Cart:BasePage
    {
        By addtocart = By.CssSelector("#shopping_cart_container > a > svg > path");

        public void addcart()
        {
            click(addtocart);
        }

    }
}
