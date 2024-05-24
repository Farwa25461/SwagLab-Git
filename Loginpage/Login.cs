using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testframework
{
    public class Login:BasePage
    {
        By usernametext = By.Id("user-name");
        By userpassword = By.Id("password");
        By loginbutton = By.Id("login-button");
        By locked_user_text = By.CssSelector("#login_button_container > div > form > h3");


        public void LoginSwagLab( string username, string password )
        {
            Maximuize();
            Thread.Sleep(1000);
            Write(usernametext, username, "UsernameDetail");     
            Write(userpassword, password, "Passworddetail");
            click(loginbutton);

        }
        public void check_assertion()
        {
            assertion_text(locked_user_text, "Epic sadface: Sorry, this user has been locked out.");
        }



    }

    
}
