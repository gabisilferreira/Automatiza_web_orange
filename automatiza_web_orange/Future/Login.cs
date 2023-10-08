using automatiza_web_orange;
using automatiza_web_orange.PageObjects;
using AutomatizaWebOrange.Steps;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Net.WebRequestMethods;


namespace AutomatizaWebOrange.Feature
{
    [TestClass]
    public class Login : Inicializacao
    {
        [TestMethod]
        [TestCategory("01")]
        public void ValidarLoginComSucesso()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário preeviamente cadastrado");
            WriteLine("Quando: Clicar no botão[Login]");
            WriteLine("Então: O login deve ser realizado com sucesso");

            LoginSteps.ValidarLoginComSucesso("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("02")]
        public void ValidarTelaLoginComUsuarioInvalido()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário não cadastrado");
            WriteLine("Quando: Clicar no botão[Login]");
            WriteLine("Então: O sistema apresentará a mensagem 'Invalid credentials' e o acesso não será permitido");

            LoginSteps.ValidarTelaLoginComUsuarioInvalido("administrador", "admin123");
        }

        [TestMethod]
        [TestCategory("03")]
        public void ValidarTelaLoginComPasswordInvalido()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com password inválido");
            WriteLine("Quando: Clicar no botão[Login]");
            WriteLine("Então: O sistema apresentará a mensagem 'Invalid credentials' e o acesso não será permitido");

            LoginSteps.ValidarTelaLoginComPasswordInvalido("Admin", "123456789132456");
        }

        [TestMethod]
        [TestCategory("04")]
        public void ValidarTelaComUsuarioObrigatorio()
        {
            WriteLine("Dado: Ao acessar o site https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            WriteLine("E: Não preencher o campo @username");
            WriteLine("E: Preencher o campo @password com valor válido");
            WriteLine("Quando: Clicar no botão[Login]");
            WriteLine("Então: O acesso não será permitido");
            WriteLine("E: Será exibido a mensagem 'Required' logo abaixo no campo @username");

            LoginSteps.ValidarTelaComUsuarioObrigatorio("", "admin123");
        }

        [TestMethod]
        [TestCategory("05")]
        public void ValidarTelaComSenhaObrigatorio()
        {
            WriteLine("Dado: Ao acessar o site https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            WriteLine("E: Preencher o campo @username com valor válido");
            WriteLine("E: Não preencher o campo @password");
            WriteLine("Quando: Clicar no botão[Login]");
            WriteLine("Então: O acesso não será permitido");
            WriteLine("E: Será exibido a mensagem 'Required' logo abaixo no campo @password");

            LoginSteps.ValidarTelaComSenhaObrigatorio("Admin", "");
        }

        [TestMethod]
        [TestCategory("06")]
        public void ValidarTrocaDeSenha()
        {
            WriteLine("Dado: Ao acessar o site https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            WriteLine("E: Preencher o campo @Username com valor válido");
            WriteLine("E: Não saber o @Password preeviamente cadastrado");
            WriteLine("Quando: Clicar no botão[Forgot your password ?]");
            WriteLine("Então: Será redirecionado ao link: https://opensource-demo.orangehrmlive.com/web/index.php/auth/requestPasswordResetCode");
            WriteLine("E: Deverá preencher o @Username preeviamente cadastrado");
            WriteLine("E: Clicar no botão [Resset Password]");
            WriteLine("E: Visualizará em sua tela a mensagem 'Reset Password link sent' ");
            WriteLine("E: Receberá em seu e-mail a mensagem de recuperação de senha");
            LoginSteps.ValidarTrocaDeSenha("Admin");
        }

       
        [TestMethod]
        [TestCategory("07")]
        public void ValidarMenuDashboardAbout()
        {
            WriteLine("Dado que: Acessar o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Logar com sucesso");
            WriteLine("Quando: Redirecionar a tela Dashboard");
            WriteLine("Então: Visualizar o menu na página Dashboard");
            WriteLine("E: Visualizar a opção About do menu");
            WriteLine("E: Ser direcionado a parte de descrição do site");
            LoginSteps.ValidarMenuDashboardAbout("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("08")]
        public void ValidarMenuDashboardSupport()
        {
            WriteLine("Dado que: Acessar o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Logar com sucesso");
            WriteLine("Quando: Redirecionar a tela Dashboard");
            WriteLine("Então: Visualizar o menu na página Dashboard");
            WriteLine("E: Visualizar a opção Support do menu");
            WriteLine("E: Redirecionar a página de suporte");
            LoginSteps.ValidarMenuDashboardSupport("Admin", "admin123");
        }
        [TestMethod]
        [TestCategory("09")]
        public void ValidarMenuDashboardChangePassword()
        {
            WriteLine("Dado que: Acessar o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Logar com sucesso");
            WriteLine("Quando: Redirecionar a tela Dashboard");
            WriteLine("Então: Visualizar o menu na página Dashboard");
            WriteLine("E: Visualizar a opção Change your Password do menu");
            WriteLine("E: Redirecionar a página Pim");
            LoginSteps.ValidarMenuDashboardChangePassword("Admin", "admin123");
        }
        [TestMethod]
        [TestCategory("10")]
        public void ValidarMenuDashboardLogout()
        {
            WriteLine("Dado que: Acessar o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Logar com sucesso");
            WriteLine("Quando: Redirecionar a tela Dashboard");
            WriteLine("Então: Visualizar o menu na página Dashboard");
            WriteLine("E: Visualizar a opção Logout do menu");
            WriteLine("E: Redirecionar a página Login");
            LoginSteps.ValidarMenuDashboardLogout("Admin", "admin123");
        }
        [TestMethod]
        [TestCategory("12")]
        public void ValidarIconeRelogio()
        {
            WriteLine("Dado que: Acessar o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Logar com sucesso");
            WriteLine("Quando: Redirecionar a tela Dashboard");
            WriteLine("Então: Visualizar aba Time at Work");
            WriteLine("E: Clicar no ícone do relógio");
            WriteLine("E: Redirecionar a página Time");
            LoginSteps.ValidarIconeRelogio("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("19")]
        public void ValidarIconeConfiguracaoEmployeesonLeaveToday()
        {
            WriteLine("Dado que: Acessar o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Logar com sucesso");
            WriteLine("Quando: Redirecionar a tela Dashboard");
            WriteLine("E: Visualizar aba Emploees on Leave Today");
            WriteLine("E: Clicar no ícone de configuração");
            WriteLine("E: Redirecionar a mensagem Configurations");
            WriteLine("E: Clicar no botão de acesso ");
            WriteLine("E: Clicar no botão Save");
            LoginSteps.ValidarIconeConfiguracaoEmployeesonLeaveToday("Admin", "admin123");
        }
        [TestMethod]
        [TestCategory("13")]
        public void ValidarIconeInterrogacao()
        {
            WriteLine("Dado que: Acessar o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Logar com sucesso");
            WriteLine("Quando  o usuário clicar no ícone de interrogação que está fixo em todas as telas");
            WriteLine("Então será direcionado a página : https://starterhelp.orangehrm.com/hc/en-us/articles/360018588480-How-to-Add-a-User-Account");   
            LoginSteps.ValidarIconeInterrogacao("Admin", "admin123");
        }


    }
}