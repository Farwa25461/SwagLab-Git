using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testframework
{
    public class CheckoutPage:BasePage
    {
        By checkoutbtn = By.CssSelector("#cart_contents_container > div > div.cart_footer > a.btn_action.checkout_button");

        public void Checkout()
        {
            click(checkoutbtn);
        }

    }
}
