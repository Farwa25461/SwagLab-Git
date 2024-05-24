using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testframework
{
    public class CheckoutInfo:BasePage
    {
        By firstname = By.Id("first-name");
        By lastname = By.Id("last-name");
        By zipcode = By.Id("postal-code");
        By continuebtn = By.CssSelector("#checkout_info_container > div > form > div.checkout_buttons > input");
        By finishbtn = By.CssSelector("#checkout_summary_container > div > div.summary_info > div.cart_footer > a.btn_action.cart_button");
        By cancle_btn = By.CssSelector("#checkout_summary_container > div > div.summary_info > div.cart_footer > a.cart_cancel_link.btn_secondary");


        public void information(string fname, string last_n, string postcode)
        {
            Write(firstname, fname, "Firstname");
            Write(lastname, last_n ,"lastname");
            Write(zipcode, postcode,"passcodedetail");

        }
        public void continue_button_user_info()
        {
            click(continuebtn);
        }

        public void finish_button_user_info()
        {
            click(finishbtn);
        }

        public void cancel_button_user_info()
        {
            click(cancle_btn);

        }

    }
}
