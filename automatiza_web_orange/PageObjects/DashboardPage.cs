using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatiza_web_orange.PageObjects
{
    public class DashboardPage
    {
        public static By pgDashboard = By.XPath("//*[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']");
        public static By nomeUsuario = By.XPath("//*[@class= 'oxd-userdropdown-name']");
        public static By btMenuDashboard = By.XPath("/html/body/div/div[1]/div[1]/header/div[1]/div[2]/ul/li/span/i");
        public static By btMenuDashboardOpcaoAbout = By.XPath("//*[(text()='About')]");
        public static By tituloAbout = By.XPath("/html/body/div/div[2]/div/div/div/div[1]/h6");
        public static By btSupport = By.XPath("//*[text()='Support']");
        public static By btChangePassword = By.XPath("//*[text()= 'Change Password']");
        public static By btLogout = By.XPath("//*[text()='Logout']");
        public static By btIconeRelogio = By.XPath("//*[@class= 'oxd-icon bi-stopwatch']");
        public static By brConfiguracao= By.XPath("//*[@class='oxd-icon bi-gear-fill orangehrm-leave-card-icon']");
        public static By MensagemConfiguracao = By.XPath("//*[@class='oxd-text oxd-text--p oxd-text--card-title']");
        public static By btSave = By.XPath("//*[@class='oxd-button oxd-button--medium oxd-button--secondary orangehrm-left-space']");
        public static By btAlteracao = By.XPath("//*[@class='oxd-switch-input oxd-switch-input--active --label-right']");
        public static By msgSucessoConf = By.XPath("//*[@class='oxd-text oxd-text--p oxd-text--toast-title oxd-toast-content-text']");
        public static By btInterrogacao = By.XPath("//*[@class='oxd-icon-button']");
    }
}
