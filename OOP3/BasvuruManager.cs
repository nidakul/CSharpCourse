using System;
namespace OOP3
{
	public class BasvuruManager
	{
		public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
		{
			creditManager.Hesapla();
			foreach (var loggerService in loggerServices)
			{
				loggerService.Log();
			}

        }

		public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
		{
			foreach (var credit in credits)
			{
				credit.Hesapla();
			}
		}
	}
}

