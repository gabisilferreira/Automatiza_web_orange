using automatiza_web_orange.PageObjects;
using AutomatizaWebOrange.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
using System.Threading.Tasks;
using automatiza_web_orange;

namespace AutomatizaWebOrange.Steps
{
    public class LoginSteps : Inicializacao
    {
        /// <summary>
        /// Método utilizado para realizar Login
        /// </summary>
        public static void Login(string Username, string Password)
        {
            
            WriteLine("Preencher campo Username");
            Driver.FindElement(LoginPage.Username).SendKeys(Username);
            
            WriteLine("Preencher campo Password");
            Driver.FindElement(LoginPage.Password).SendKeys(Password);
            
            WriteLine("Realizar o click no botão Login");

            Driver.FindElement(LoginPage.Login).Click();
        }

        public static void ValidarLoginComSucesso(string Username, string Password)
        {
            Login(Username, Password);

            Thread.Sleep(5000);
            WriteLine("Validação realizada pela descrição 'Dashboard' na tela");
            string LoginSucesso = Convert.ToString(Driver.FindElement(DashboardPage.pgDashboard).Text);
            Assert.AreEqual("Dashboard", LoginSucesso, "Login foi realizado com sucesso");

            WriteLine("Validação realizada pela link da página Dashboard");
            string pgDashboardEsperado = "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index";
            string pgDashboardAtual = Convert.ToString(Driver.Url);
            Assert.AreEqual(pgDashboardEsperado, pgDashboardAtual, "Login foi realizado com sucesso");
        }

        public static void ValidarTelaLoginComUsuarioInvalido(string Username, string Password)
        {
            Login(Username, Password);

            WriteLine("Realizar a validação com usuário inválido");
            string UsernameInvalido = Convert.ToString(Driver.FindElement(LoginPage.UsernamePasswordInvalido).Text);
            Assert.AreEqual("Invalid credentials", UsernameInvalido, "Usuário inválido conforme esperado");
        }

        public static void ValidarTelaLoginComPasswordInvalido(string Username, string Password)
        {
            Login(Username, Password);

            WriteLine("Realizar a validação com senha inválida");
            string PasswordInvalido = Convert.ToString(Driver.FindElement(LoginPage.UsernamePasswordInvalido).Text);
            Assert.AreEqual("Invalid credentials", PasswordInvalido, "Senha inválida conforme esperado");
        }

        public static void ValidarTelaComUsuarioObrigatorio(string Username, string Password)
        {
            Login(Username, Password);

            Thread.Sleep(5000);
            WriteLine("Campo obrigatório Username validado com sucesso");
            string UsernameObrigatorio = Convert.ToString(Driver.FindElement(LoginPage.CampoObrigatorio).Text);
            Assert.AreEqual("Required", UsernameObrigatorio, "Campo obrigatório Username validado com sucesso");
        }

        public static void ValidarTelaComSenhaObrigatorio(string Username, string Password)
        {
            Login(Username, Password);

            Thread.Sleep(5000);
            WriteLine("Campo obrigatório Password validado com sucesso");
            string PasswordObrigatorio = Convert.ToString(Driver.FindElement(LoginPage.CampoObrigatorio).Text);
            Assert.AreEqual("Required", PasswordObrigatorio, "Campo obrigatório Password validado com sucesso");
        }

        public static void ValidarTrocaDeSenha(string Username)
        {
            Thread.Sleep(5000);
            WriteLine("Preencher campo Username");
            Driver.FindElement(LoginPage.Username).SendKeys(Username);

            WriteLine("Clicar no botão [Forgot Your Password]");
            Driver.FindElement(LoginPage.btForgotYourPassword).Click();

            WriteLine("Validar se redirecionou para a página 'Forgot Your Password'");
            string pgForgotYourPasswordAtual = Convert.ToString(Driver.Url);
            string pgForgotYourPasswordEsperado = Convert.ToString("https://opensource-demo.orangehrmlive.com/web/index.php/auth/requestPasswordResetCode");
            Assert.AreEqual(pgForgotYourPasswordEsperado, pgForgotYourPasswordAtual, "Página carregada com sucesso!");

            RequestPasswordResetCodeSteps.ValidarRecuperarSenha(Username);

            WriteLine("Validar se redirecionou para a página 'Send Password Reset'");
            string pgSendPasswordResetAtual = Convert.ToString(Driver.Url);
            string pgSendPasswordResetEsperado = Convert.ToString("https://opensource-demo.orangehrmlive.com/web/index.php/auth/sendPasswordReset");
            Assert.AreEqual(pgSendPasswordResetEsperado, pgSendPasswordResetAtual, "Página carregada com sucesso!");

            WriteLine("Validar se exibiu a mensagem 'Reset Password link sent successfully' ");
            string msgSendPasswordResetAtual = Convert.ToString(Driver.FindElement(SendPasswordResetPage.msgSendPasswordReset).Text);
            Assert.AreEqual("Reset Password link sent successfully", msgSendPasswordResetAtual, "Página carregada com sucesso!");
        }


        public static void ValidarMenuDashboardAbout(string Username, string Password)
        {
            Login(Username, Password);
            WriteLine("Validar Menu Dashboard");
            Thread.Sleep(5000);
            Driver.FindElement(DashboardPage.btMenuDashboard).Click();
            Thread.Sleep(5000);
            WriteLine("Validar Opção About");
            Driver.FindElement(DashboardPage.btMenuDashboardOpcaoAbout).Click();
            Thread.Sleep(5000);
            string OpcaoAbout = Convert.ToString(Driver.FindElement(DashboardPage.tituloAbout).Text);
            Assert.AreEqual("About", OpcaoAbout, "Opção carregada com sucesso!");
        }

        public static void ValidarMenuDashboardSupport(string Username, string Password)
        {
            Login(Username, Password);
            WriteLine("Validar Menu Dashboard");
            Thread.Sleep(5000);
            Driver.FindElement(DashboardPage.btMenuDashboard).Click();
            Thread.Sleep(5000);
            WriteLine("Validar Opção Support");
            Driver.FindElement(DashboardPage.btSupport).Click();
            Thread.Sleep(5000);
            string OpcaoSupport = Convert.ToString(Driver.FindElement(SupportPage.pgSuport).Text);
            Assert.AreEqual("Getting Started with OrangeHRM", OpcaoSupport, "Menu Support carregado com sucesso!");
        }
        public static void ValidarMenuDashboardChangePassword(string Username, string Password)
        {
            Login(Username, Password);
            WriteLine("Validar Menu Dashboard");
            Thread.Sleep(5000);
            Driver.FindElement(DashboardPage.btMenuDashboard).Click();
            Thread.Sleep(5000);
            WriteLine("Validar Opção Change Password");
            Driver.FindElement(DashboardPage.btChangePassword).Click();
            Thread.Sleep(5000);
            string OpcaoPim = Convert.ToString(Driver.FindElement(PimPage.pgPim).Text);
            Assert.AreEqual("PIM", OpcaoPim, "Menu Pim carregado com sucesso!");
        }
        public static void ValidarMenuDashboardLogout(string Username, string Password)
        {
            Login(Username, Password);
            WriteLine("Validar Menu Dashboard");
            Thread.Sleep(5000);
            Driver.FindElement(DashboardPage.btMenuDashboard).Click();
            Thread.Sleep(5000);
            WriteLine("Validar Opção Logout");
            Driver.FindElement(DashboardPage.btLogout).Click();
            Thread.Sleep(5000);
            string Logout = Convert.ToString(Driver.FindElement(LoginPage.pgLogin).Text);
            Assert.AreEqual("Login", Logout, "Logout realizado com sucesso!");
        }
        public static void ValidarIconeRelogio(string Username, string Password)
        {
            Login(Username, Password);
            WriteLine("Validar ícone relógio que fica na aba Time at Work");
            Driver.FindElement(DashboardPage.btIconeRelogio).Click();
            string time = Convert.ToString(Driver.FindElement(TimePage.pgTime).Text);
            Assert.AreEqual("Attendance", time, "Ícone validado com sucesso!");
        }
        public static void ValidarIconeConfiguracaoEmployeesonLeaveToday(string Username, string Password)
        {
            Login(Username, Password);
            WriteLine("Validar ícone configuração na aba Employees on Leave Today");
            Driver.FindElement(DashboardPage.brConfiguracao).Click();
            Thread.Sleep(3000);
            Driver.FindElement(DashboardPage.MensagemConfiguracao);
            Thread.Sleep(3000);
            Driver.FindElement(DashboardPage.btAlteracao).Click();
            Thread.Sleep(3000);
            Driver.FindElement(DashboardPage.btSave).Click();
            string sucesso = Convert.ToString(Driver.FindElement(DashboardPage.msgSucessoConf).Text);
            Assert.AreEqual("Success", sucesso, "Ícone configuração validado com sucesso!");
        }
        public static void ValidarIconeInterrogacao(string Username, string Password)
        {
            Login(Username, Password);
            WriteLine("Validar ícone de interrogação na parte superior da página");
            Driver.FindElement(DashboardPage.btInterrogacao).Click();
            Thread.Sleep(3000);
            string pgDuvidaEsperado = "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index";
            string pgDuvidadAtual = Convert.ToString(Driver.Url);
            Assert.AreEqual(pgDuvidaEsperado, pgDuvidadAtual, "Redirecionamento realizado com sucesso");
        }




    }
}