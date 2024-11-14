using OpenQA.Selenium;
using OfficeOpenXml;
using OpenQA.Selenium.Chrome;




namespace SeleniumBot

{
    public class AutomationWeb
    {
        public IWebDriver driver;

        public AutomationWeb()
        {
            driver = new ChromeDriver();
        }

        public void testWeb()
        {
            driver.Navigate().GoToUrl("https://transnet.grupocsc.com.br/sgtweb/index.php?c=controleAcesso.CMenu&m=verMenu");

            driver.FindElement(By.Name("edtLogin")).SendKeys("LETICIASILVA");

            driver.FindElement(By.Name("edtSenha")).SendKeys("Grupo*@*66478");

            driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/div[5]/div/input")).Click();


            driver.Navigate().GoToUrl("https://transnet.grupocsc.com.br/sgtweb/index.php?c=compras.CCpAcompanhamentoSoliCompra&m=verPesquisar&idFuncaoLog=513967&idModulo=4978");

            driver.FindElement(By.XPath("//*[@id=\"visualizacao\"]")).Click();

            driver.FindElement(By.XPath("//*[@id=\"visualizacao\"]/option[3]")).Click(); 

            //driver.FindElement(By.XPath("//*[@id=\"conteudoNav\"]/div[3]/div/a")).Click();

       



            //string downloadFolder = @"C:\Users\SeuUsuario\Downloads"; // Substitua pelo caminho onde os arquivos são baixados
            //string downloadedFile = Path.Combine(downloadFolder, "nome_do_arquivo_baixado.xlsx");  // Nome do arquivo baixado

            // Aguardar até que o arquivo esteja presente no diretório de downloads
           // WaitForFileToDownload(downloadedFile);

            // Agora que o arquivo foi baixado, podemos abrir a planilha
            //ReadExcelFile(downloadedFile);
        }






    }

        
    }

