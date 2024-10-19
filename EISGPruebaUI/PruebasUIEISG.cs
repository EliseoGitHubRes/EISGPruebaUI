using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace EISGPruebaUI
{
	[TestClass]
	public class PruebasUIEISG : IDisposable
	{
		private IWebDriver driver;

		public PruebasUIEISG()
		{
			driver = new ChromeDriver();
		}

		[TestMethod]
		public void Prueba_Blazor()
		{
			driver.Navigate().GoToUrl("https://localhost:7294/product-list");

			System.Threading.Thread.Sleep(1000);

			var btn = driver.FindElement(By.Id("crear"));

			btn.Click();

			System.Threading.Thread.Sleep(1000);

			var nombre = driver.FindElement(By.Id("NombreEISG"));

			nombre.SendKeys("PruebaUI5");

			var precio = driver.FindElement(By.Id("PrecioEISG"));

			precio.SendKeys("55555");

			var descripcion = driver.FindElement(By.Id("DescripcionEISG"));

			descripcion.SendKeys("Es la prueba UI5");

		

			var guardar = driver.FindElement(By.Id("guardar"));

			guardar.Click();

			System.Threading.Thread.Sleep(1000);

			var regresar = driver.FindElement(By.Id("regresar"));

			regresar.Click();

			System.Threading.Thread.Sleep(1000);

		}

		public void Dispose()
		{
			driver.Quit();
		}
	}
}
