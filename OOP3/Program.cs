using OOP3;

ICreditManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();

ICreditManager tasıtKrediManager = new TasıtKrediManager();
//tasıtKrediManager.Hesapla();

ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();

BasvuruManager basvuruManager = new BasvuruManager();
//basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()});
//basvuruManager.BasvuruYap(new IhtiyacKrediManager());

List<ICreditManager> credits = new List<ICreditManager>() {konutKrediManager, tasıtKrediManager, ihtiyacKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(credits);

