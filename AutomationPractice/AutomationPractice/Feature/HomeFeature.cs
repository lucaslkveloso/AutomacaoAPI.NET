using AutomationPractice.Base;
using AutomationPractice.Steps;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace AutomationPractice.Feature
{
   public class HomeFeature : BaseTests
    {
        public HomeFeature(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void TesteCompleto()
        {
            HomePageSteps.ClicarNoProduto1();
            HomePageSteps.ClicarEmAddCart();
            CartSteps.ProsseguirParaCarrinho();
            CartSteps.Prosseguir();
            SignInSteps.CriarEmail();
            SignInSteps.CriarConta();
            AddressSteps.EscolherEndereco();
            ShoppingSteps.ProsseguirCompra();
            PaymentSteps.FormaDePagamentoCartao();
            PaymentSteps.MudarFormaDePagamento();
            PaymentSteps.FormaDePagamentoCheck();
            PaymentSteps.FinalizarCompra();
            HomePageSteps.ContaLogada();
            MyAccountSteps.AcessarHistoricoDecompras();
            MyAccountSteps.VoltarParaHomePage();
            

        }
        public static IEnumerable<object[]> DadosDoCliente()
        {
            string cpf = "12278926710";
            string telefone = "41993450256";
            string numeroCartao = "5323 7545 8120 4543";
            string idade = "36";
            string numeroRg = "324112506";
            string cep = "49008336";

            yield return new[] { cpf, telefone, numeroCartao, idade, numeroRg, cep };


        }
    }
}
