using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_uygulamasi_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankamatik Uygulamasına Hoşgeldiniz");
            Console.WriteLine("************");
            double bakiye = 250;
            string sifre = "ab18";
            int yanlis_sifre_sayisi = 0;
            bool kartli_islem = false;
            int lockoutDurationInHours = 1;
            int hata = 0;

            string tc = "11";
            string telefon = "22";
            Console.WriteLine("İşlem Türünü seçiniz  1- Kartlı / 2- Kartsız");
            int islem = Convert.ToInt32(Console.ReadLine());






            while (islem == 1)
            {
                if (!kartli_islem)
                {
                    Console.WriteLine("Kartlı İşlem menüsü");
                    Console.WriteLine("*******");

                    Console.WriteLine("Şifre giriniz : ");
                    string girilen_sifre = Console.ReadLine();

                    if (girilen_sifre != sifre)
                    {
                        yanlis_sifre_sayisi++;
                        if (yanlis_sifre_sayisi >= 3)
                        {
                            Console.WriteLine("3 defa hatalı şifre girişi yaptınız.");
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Yanlış şifre girişi yaptınız kalan deneme sayısı : " + (3 - yanlis_sifre_sayisi));
                            continue;
                        }


                    }
                    else
                    {
                        Console.WriteLine("Girilen şifre Doğru Ana Menüye Gönderiliyorsunuz...");
                        Console.WriteLine();
                        kartli_islem = true;
                        continue;

                    }

                }
                break;
            }
            while (islem == 1)
            {
                Console.WriteLine("Ana Menüye Hoşgeldiniz");
                Console.WriteLine("İşelm 1 - Para çek");
                Console.WriteLine("İşelm 2 - Para yatır");
                Console.WriteLine("İşelm 3 - Para transferi");
                Console.WriteLine("İşelm 4 -Eğitim ödemeleri");
                Console.WriteLine("İşelm 5 - Ödemeler ");
                Console.WriteLine("İşelm 6 - Bİlgi güncelleme");
                Console.WriteLine("İşelm 9 -Ana menüye dönüş");
                Console.WriteLine("İşelm 0 - Çıkış");

                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("Para Çekme menüsü..");
                    Console.WriteLine("Çekilecek para miktarını giriniz : ");
                    int cekilen_para = Convert.ToInt32(Console.ReadLine());

                    if (cekilen_para < 250)
                    {
                        bakiye -= cekilen_para;
                        Console.WriteLine("Para çekme işlemi başarılı  Kalan bakiye: " + bakiye);
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Limit ....");



                    }
                }

                else if (secim == 2)
                {
                    Console.WriteLine("Para Yatırma Menüsü ...");
                    Console.WriteLine("Yatırmak istedğiniz tutarı giriniz : ");
                    int yatırılan_para = Convert.ToInt32(Console.ReadLine());
                    bakiye = +yatırılan_para;
                    Console.WriteLine("Para Yatırma Islemi Başarılı Yeni Bakiye : " + (bakiye + yatırılan_para));
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Para transfer Menüsü...");
                    Console.WriteLine("EFT için - 1");
                    Console.WriteLine("Havale için - 2 ");
                    int secim2 = Convert.ToInt32(Console.ReadLine());
                    if (secim2 == 1)
                    {
                        Console.WriteLine("Eft yapmak istediğiniz numarayı giriniz : ");
                        string eft_numarası = Console.ReadLine();
                        Console.WriteLine("Ne kadar para transfer etmek istiyorsunuz : ");
                        int eft_transfer = Convert.ToInt32(Console.ReadLine());

                        if (eft_numarası.StartsWith("tr") && eft_numarası.Length == 14 && (bakiye - eft_transfer >= 0))
                        {
                            Console.WriteLine("İşlem başarılı...");
                            Console.WriteLine("Kalan Bakiyie " + (bakiye - eft_transfer));

                        }
                        else
                        {
                            Console.WriteLine("Hatalı giriş yaptınız ");
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz.. ");
                            System.Threading.Thread.Sleep(3000);

                        }

                    }
                    else if (secim2 == 2)
                    {
                        Console.WriteLine("Havale Yapılacak Numarayı giriniz ");
                        string havale = Console.ReadLine();
                        if (havale.Length == 11)
                        {
                            Console.WriteLine("Ne kadar havale yapmak istiyorsunuz : ");
                            double havale1 = Convert.ToDouble(Console.ReadLine());
                            if (bakiye - havale1 >= 0)
                            {
                                Console.WriteLine("İşelm başarlı Güncel bakiye : " + (bakiye - havale1));
                                Console.WriteLine("Ana menüye yönlendiriliyorsunuz ");
                                System.Threading.Thread.Sleep(3000);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                                System.Threading.Thread.Sleep(2000);

                            }


                        }

                    }

                }
                else if (secim == 4)
                {
                    Console.WriteLine("Eğitim ödemeleri için işlemler şuan bakımdadır.....");
                    Console.WriteLine("Ana menüye yönelendiriliyorsunuz ...");
                    System.Threading.Thread.Sleep(2000);

                }

                else if (secim == 5)
                {

                    Console.WriteLine("Ödeme sayfasına Hoşgeldiniz");
                    Console.WriteLine("1-  Elektrik Faturası ");
                    Console.WriteLine("2- Telefon Faturası ");
                    Console.WriteLine("3- İnternet Faturası ");
                    Console.WriteLine("4- Su Faturası ");
                    Console.WriteLine("5- OGS Ödemeleri ");
                    Console.WriteLine();
                    Console.WriteLine("Lütfen Bir Seçim Yapınız...");
                    int secim3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ücret giriniz");


                    if (secim3 == 1)
                    {

                        Console.WriteLine("Fatura Tutarı giriniz : ");
                        int tutar1 = Convert.ToInt32(Console.ReadLine());
                        if (bakiye >= tutar1)
                        {
                            Console.WriteLine("İşelm Başarılı Güncel bakiye : " + (bakiye - tutar1));

                        }
                        else
                        {
                            Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                            System.Threading.Thread.Sleep(2000);
                        }

                    }
                    else if (secim3 == 2)
                    {
                        Console.WriteLine("Fatura Tutarı giriniz : ");
                        int tutar = Convert.ToInt32(Console.ReadLine());
                        if (bakiye - tutar >= 0)
                        {
                            Console.WriteLine("İşelm Başarılı Güncel bakiye : " + (tutar - bakiye));

                        }
                        else
                        {
                            Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    else if (secim3 == 3)
                    {
                        Console.WriteLine("Fatura Tutarı giriniz : ");
                        double tutar3 = Convert.ToInt32(Console.ReadLine());
                        if (bakiye - tutar3 >= 0)
                        {
                            Console.WriteLine("İşelm Başarılı Güncel bakiye : " + (tutar3 - bakiye));

                        }
                        else
                        {
                            Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                            System.Threading.Thread.Sleep(2000);
                        }

                    }
                    else if (secim3 == 4)
                    {
                        Console.WriteLine("Fatura Tutarı giriniz : ");
                        int tutar4 = Convert.ToInt32(Console.ReadLine());
                        if (bakiye - tutar4 >= 0)
                        {
                            Console.WriteLine("İşelm Başarılı Güncel bakiye : " + (tutar4 - bakiye));

                        }
                        else
                        {
                            Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    else if (secim3 == 5)
                    {
                        Console.WriteLine("Fatura Tutarı giriniz : ");
                        double tutar5 = Convert.ToDouble(Console.ReadLine());
                        if (bakiye - tutar5 >= 0)
                        {
                            Console.WriteLine("İşelm Başarılı Güncel bakiye : " + (tutar5 - bakiye));

                        }
                        else
                        {
                            Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                        System.Threading.Thread.Sleep(2000);

                    }



                }

                else if (secim == 6)
                {
                    Console.WriteLine("Yeni bir şifre Giriniz : ");
                    string yeni_sifre = Console.ReadLine();

                    Console.Write("Şİfre Güncellendi...");
                    Console.WriteLine("Ana Menüye Yönllendiriliyorsunuz...");
                    System.Threading.Thread.Sleep(2000);



                }


                else if (secim == 0)
                {
                    break;
                }
            }

            while (true)
            {
                if (!kartli_islem)
                {
                    Console.WriteLine("Kartlı İşlem menüsü");
                    Console.WriteLine("*******");

                    Console.WriteLine("Şifre giriniz : ");
                    string girilen_sifre = Console.ReadLine();

                    if (girilen_sifre != sifre)
                    {
                        yanlis_sifre_sayisi++;
                        if (yanlis_sifre_sayisi >= 3)
                        {
                            Console.WriteLine("3 defa hatalı şifre girişi yaptınız.");
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Yanlış şifre girişi yaptınız kalan deneme sayısı : " + (3 - yanlis_sifre_sayisi));
                            continue;
                        }


                    }
                    else
                    {
                        Console.WriteLine("Girilen şifre Doğru Ana Menüye Gönderiliyorsunuz...");
                        Console.WriteLine();
                        kartli_islem = true;
                        continue;

                    }

                }
                break;
            }
            while (islem == 2)
            {
                Console.WriteLine("Bankamatik Uygulamasına Hoşgeldiniz");
                Console.WriteLine("Kartsız İşlemler");
                Console.WriteLine("************");
                Console.WriteLine();

                Console.WriteLine("CepBank Para Çekme İşlemleri - 1");
                Console.WriteLine("Para Yatırma İşlemleri - 2");
                Console.WriteLine("Kredi Kartı Ödeme - 3");
                Console.WriteLine("Eğitim Ödemeleri - 4");
                Console.WriteLine("Ödemeler -  5");
                Console.WriteLine();

                Console.WriteLine("Lütfen bir Seçim yapınız : ");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {

                    while (hata < 3)
                    {
                        Console.Write("TC Kimlik No: ");
                        string tcKimlikNo = Console.ReadLine();

                        Console.Write("Cep Telefonu Numarası: ");
                        string phoneNumber = Console.ReadLine();

                        if (tcKimlikNo == tc && phoneNumber == telefon)
                        {
                            Console.WriteLine("Doğrulama Başarılı!");
                            Console.WriteLine("Kişiye 1000 ödeme yapılıyor Güncel Bakiye : " + (bakiye + 1000));
                            Console.WriteLine("Ana Menüye Dönülüyor ");
                            System.Threading.Thread.Sleep(2000);
                            break;

                        }
                        else
                        {
                            hata++;
                            Console.WriteLine("Hatalı TC Kimlik No veya cep telefonu numarası. Kalan deneme hakkı: " + (3 - hata));
                        }
                    }

                    if (hata == 3)
                    {
                        DateTime lockoutEndTime = DateTime.Now.AddHours(lockoutDurationInHours);
                        Console.WriteLine("Deneme hakkınız bitti. Sistem 1 saat kilitlendi. Lütfen daha sonra tekrar deneyin.");
                        Console.WriteLine("Kilitleme süresi sona erme tarihi ve saati: " + lockoutEndTime.ToString());
                    }



                }
                else if (secim == 2)
                {

                    while (true)
                    {
                        Console.WriteLine("Nakit ile Para Yatırmak için -1 ");
                        Console.WriteLine("Kart ile Para Yatırmak için -2");
                        int yatırma = Convert.ToInt32(Console.ReadLine());
                        if (yatırma == 1)
                        {
                            Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz : ");
                            int tutar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("İşlem Başarılı Güncel Bakiye : " + (bakiye + tutar));
                            Console.WriteLine("Sistemden Çıkış Yapılıyor...");
                            System.Threading.Thread.Sleep(2000);
                            break;

                        }
                        else if (yatırma == 2)
                        {
                            Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz : ");
                            int tutar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("İşlem Başarılı Güncel Bakiye : " + (bakiye + tutar));
                            Console.WriteLine("Ana Menüye dönülüyor...");
                            System.Threading.Thread.Sleep(2000);
                            break;

                        }
                    }
                }


                else if (secim == 3)
                {
                    Console.WriteLine("Kredi Kartı Borcunu Giriniz : ");
                    int tutar1 = Convert.ToInt32(Console.ReadLine());
                    if (bakiye >= tutar1)
                    {
                        Console.WriteLine("İşelm Başarılı Güncel bakiye : " + (bakiye - tutar1));
                        Console.WriteLine("Ana Menüye dönülüyor...");
                        System.Threading.Thread.Sleep(2000);

                    }
                    else
                    {
                        Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                else if (secim == 4)
                {
                    Console.WriteLine("Bu sistem Bakımdadır..");
                    Console.WriteLine("Ana Menüye dönülüyor...");
                    System.Threading.Thread.Sleep(2000);



                }
                else if (secim == 5)
                {
                    Console.WriteLine("Ödeme sayfasına Hoşgeldiniz");
                    Console.WriteLine("1-  Elektrik Faturası ");
                    Console.WriteLine("2- Telefon Faturası ");
                    Console.WriteLine("3- İnternet Faturası ");
                    Console.WriteLine("4- Su Faturası ");
                    Console.WriteLine("5- OGS Ödemeleri ");
                    Console.WriteLine();
                    Console.WriteLine("Lütfen Bir Seçim Yapınız...");
                    int secim3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ücret giriniz");


                    if (secim3 == 1)
                    {

                        Console.WriteLine("Fatura Tutarı giriniz : ");
                        int tutar1 = Convert.ToInt32(Console.ReadLine());
                        if (bakiye >= tutar1)
                        {
                            Console.WriteLine("İşelm Başarılı Güncel bakiye : " + (bakiye - tutar1));
                            Console.WriteLine("İşlem Sonlanıyor");
                            Console.WriteLine("Ana Menüye dönülüyor ");
                            System.Threading.Thread.Sleep(2000);

                        }
                        else
                        {
                            Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                            System.Threading.Thread.Sleep(2000);
                        }

                    }
                    else if (secim3 == 2)
                    {
                        Console.WriteLine("Fatura Tutarı giriniz : ");
                        int tutar = Convert.ToInt32(Console.ReadLine());
                        if (bakiye - tutar >= 0)
                        {
                            Console.WriteLine("İşelm Başarılı Güncel bakiye : " + (tutar - bakiye));
                            Console.WriteLine("İşlem Sonlanıyor");
                            Console.WriteLine("Ana Menüye dönülüyor ");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    else if (secim3 == 3)
                    {
                        Console.WriteLine("Fatura Tutarı giriniz : ");
                        double tutar3 = Convert.ToInt32(Console.ReadLine());
                        if (bakiye - tutar3 >= 0)
                        {
                            Console.WriteLine("İşelm Başarılı Güncel bakiye : " + (tutar3 - bakiye));
                            Console.WriteLine("İşlem Sonlanıyor");
                            Console.WriteLine("Ana Menüye dönülüyor ");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                            System.Threading.Thread.Sleep(2000);
                        }

                    }
                    else if (secim3 == 4)
                    {
                        Console.WriteLine("Fatura Tutarı giriniz : ");
                        int tutar4 = Convert.ToInt32(Console.ReadLine());
                        if (bakiye - tutar4 >= 0)
                        {
                            Console.WriteLine("İşelm Başarılı Güncel bakiye : " + (tutar4 - bakiye));
                            Console.WriteLine("İşlem Sonlanıyor");
                            Console.WriteLine("Ana Menüye dönülüyor ");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    else if (secim3 == 5)
                    {
                        Console.WriteLine("Fatura Tutarı giriniz : ");
                        double tutar5 = Convert.ToDouble(Console.ReadLine());
                        if (bakiye - tutar5 >= 0)
                        {
                            Console.WriteLine("İşelm Başarılı Güncel bakiye : " + (tutar5 - bakiye));
                            Console.WriteLine("İşlem Sonlanıyor");
                            Console.WriteLine("Ana Menüye dönülüyor ");
                            System.Threading.Thread.Sleep(2000);

                        }
                        else
                        {
                            Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Hatalı bir giriş yaptınız Ana menüye yönlendiriliyorsunuz... ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(2000);

                    }
                }
                else if (secim == 0)
                {
                    Console.WriteLine("Sistemden Çıkış Yapılıyor...");
                    System.Threading.Thread.Sleep(2000);
                    break;


                }








            }






        }
    }
}
    

