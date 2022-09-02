//Bibliotecas

using System; //biblioteca prncipal do Microsoft .net/windows
using NUnit.Framework; // conjunto de ferramentas chamada NUnit
using OpenQA.Selenium; // selenium webdriver
using OpenQA.Selenium.Chrome; //escolhi o google chrome para rodar o teste
using OpenQA.Selenium.DevTools.V102.Runtime;

//NameSpace  =  Conjunto de classes

namespace TestLink
{

    // Classe = Entidade do Software

    public class Usuario
    {

        // Informa��es = Atributos (informa��es , dados , campos , caracteristicas

        string baseURL; // endere�o do site que ser� testado 
        IWebDriver selenium; //Objeto Selenium

        // M�todos = Fun��es ou (e) funcionalidades
        [Test]
        public void LoginPositivo()
        {

            // Preparar
            baseURL = "https://prd-corretorweb-pwa.azurewebsites.net/";
            selenium = new ChromeDriver(); // instanciou o selenium com o chrome (para ficar comercial posso criar um script depois colicando driver no lugar de selenium)

            // Executar
            selenium.Navigate().GoToUrl(baseURL); // vai abrir o chrome no endere�o
            Thread.Sleep(1000); // espera 1 segundos
            
            //limpa a caixa de texto login e escreve usu�rio

            selenium.FindElement(By.Id("usuario")).Clear();
            selenium.FindElement(By.Id("usuario")).SendKeys("03329290196");

            //limpa a caixa de texto senha e escreve senha

            selenium.FindElement(By.Id("password")).Clear();
            selenium.FindElement(By.Id("password")).SendKeys("Gabriel123");

            //clicar no bot�o entrar 

            selenium.FindElement(By.ClassName("MuiButton-label")).Click();
            Thread.Sleep(10000);


            selenium.Quit(); // encerra o negador


        }
    }

}