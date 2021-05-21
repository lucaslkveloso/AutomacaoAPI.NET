using AutomationPractice.Base;
using AutomationPractice.PageObject;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace AutomationPractice.Steps
{
   public class MyAccountSteps : BaseTests
    {
        public MyAccountSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
        public static void AcessarHistoricoDecompras()
        {
            Report.Log("clicar nos historico do compras");
            WebDriver.FindElement(HomePage.HistoricoDeCompras).Click();
            Assert.True(WebDriver.FindElement(HomePage.Home).Displayed);
        }
        public static void VoltarParaHomePage()
        {
            Report.Log("clicar em home para voltar para homepage");
            WebDriver.FindElement(HomePage.Home).Click();
        }
        
    }
}
