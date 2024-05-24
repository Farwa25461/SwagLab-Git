using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;

namespace testframework
{
    [AllureNUnit]
    [TestFixture]
    public class Tests:BasePage
    {
        Login login= new Login();
        ProductPage productpage = new ProductPage();
        Cart cart = new Cart();
        CheckoutPage checkoutpage = new CheckoutPage();
        CheckoutInfo checkoutinfo = new CheckoutInfo();
        Menu menu = new Menu();
        [SetUp]
        public void Setup()
        {
            
            SeleniumInit("https://www.saucedemo.com/v1/");          
        }

        [TearDown]
        public void Teardown()
        { 
            driver.Close();
        }

        [Test]
        [AllureStep]

        public void userlogin_with_happypath()
        {
            login.LoginSwagLab("standard_user", "secret_sauce");
            productpage.Selectproducts();
            cart.addcart();
            checkoutpage.Checkout();
            checkoutinfo.information("Farwa", "Ramzan", "123");
            checkoutinfo.continue_button_user_info();

        }
        [Test]
        [AllureStep]
        public void userlogin_locked()
        {
            login.LoginSwagLab("locked_out_user", "secret_sauce");
            login.check_assertion();
        }

        [Test]
        [AllureStep]
        public void Reverse_order()
        {
            login.LoginSwagLab("standard_user", "secret_sauce");
            productpage.Selectproducts();
            cart.addcart();
            checkoutpage.Checkout();
            checkoutinfo.information("Farwa", "Ramzan", "123");
            checkoutinfo.continue_button_user_info();

            Thread.Sleep(2000);
            checkoutinfo.cancel_button_user_info();

            Thread.Sleep(2000);
            productpage.Selectproducts();

            menu.menu_click();
            Thread.Sleep(3000);
            menu.log_out();


        }




    }
}