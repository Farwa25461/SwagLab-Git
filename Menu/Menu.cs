using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testframework
{
    public class Menu:BasePage
    {
        By menubar = By.ClassName("bm-burger-button");
        By logout = By.Id("logout_sidebar_link");


        public void menu_click()
        {
            click(menubar);
        }

        public void log_out()
        {
            click(logout);
        }


    }
}
