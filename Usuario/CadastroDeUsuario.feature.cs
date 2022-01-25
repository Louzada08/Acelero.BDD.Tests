﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Acelero.BDD.Tests.Usuario
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class Usuario_CadastroFeature : object, Xunit.IClassFixture<Usuario_CadastroFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CadastroDeUsuario.feature"
#line hidden
        
        public Usuario_CadastroFeature(Usuario_CadastroFeature.FixtureData fixtureData, Acelero_BDD_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Usuario", "Usuário - Cadastro", "\tComo um visitante da loja\r\n\tEu desejo me cadastrar como usuário\r\n\tPara que eu po" +
                    "ssa realizar compras na loja", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Cadastro de usuário com sucesso")]
        [Xunit.TraitAttribute("FeatureTitle", "Usuário - Cadastro")]
        [Xunit.TraitAttribute("Description", "Cadastro de usuário com sucesso")]
        public virtual void CadastroDeUsuarioComSucesso()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de usuário com sucesso", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
testRunner.Given("Que o visitante está acessando o site da loja", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 8
testRunner.When("Ele clicar em registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Dados"});
                table1.AddRow(new string[] {
                            "E-mail"});
                table1.AddRow(new string[] {
                            "Senha"});
                table1.AddRow(new string[] {
                            "Confirmação da Senha"});
#line 9
testRunner.And("Preencher os dados do formulario", ((string)(null)), table1, "E ");
#line hidden
#line 14
testRunner.And("Clicar no botão registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 15
testRunner.Then("Ele será redirecionado para a vitrine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
#line 16
testRunner.And("Uma saudação com seu e-mail será exibida no menu superior", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Cadastro com senha sem maiusculas")]
        [Xunit.TraitAttribute("FeatureTitle", "Usuário - Cadastro")]
        [Xunit.TraitAttribute("Description", "Cadastro com senha sem maiusculas")]
        public virtual void CadastroComSenhaSemMaiusculas()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro com senha sem maiusculas", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
testRunner.Given("Que o visitante está acessando o site da loja", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 20
testRunner.When("Ele clicar em registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Dados"});
                table2.AddRow(new string[] {
                            "E-mail"});
                table2.AddRow(new string[] {
                            "Senha"});
                table2.AddRow(new string[] {
                            "Confirmação de senha"});
#line 21
testRunner.And("Preencher os dados do formulario com uma senha sem maiusculas", ((string)(null)), table2, "E ");
#line hidden
#line 26
testRunner.And("Clicar no botão registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 27
testRunner.Then("Ele receberá uma mensagem de erro que a senha precisa conter uma letra maiuscula", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Cadastro com senha sem caractere especial")]
        [Xunit.TraitAttribute("FeatureTitle", "Usuário - Cadastro")]
        [Xunit.TraitAttribute("Description", "Cadastro com senha sem caractere especial")]
        public virtual void CadastroComSenhaSemCaractereEspecial()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro com senha sem caractere especial", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 30
testRunner.Given("Que o visitante está acessando o site da loja", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 31
testRunner.When("Ele clicar em registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Dados"});
                table3.AddRow(new string[] {
                            "E-mail"});
                table3.AddRow(new string[] {
                            "Senha"});
                table3.AddRow(new string[] {
                            "Confirmação de senha"});
#line 32
testRunner.And("Preencher os dados do formulario com uma senha sem caractere especial", ((string)(null)), table3, "E ");
#line hidden
#line 37
testRunner.And("Clicar no botão registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 38
testRunner.Then("Ele receberá uma mensagem de erro que a senha precisa conter um caractere especia" +
                        "l", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                Usuario_CadastroFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                Usuario_CadastroFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
