using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreditKarti5
{

    //ilk olaraq kart klasini yaradiriq
    class Kart
    {
        //2- ci propertilerimii veririk
        string userName = "Cavidan";
        string passWord = "Ekberov";

        string nameSurName = "Cavidan Ekberov";
        string cardNumber = "589641235789";
        string expireDate = DateTime.Now.AddYears(10).ToString("MM/yyyy");
        int cvc = 345;
        int Money = 50000;
        string currency = "Dollar";

        //3 - cu konstruktor yaradiriq
        public Kart(string _userName, string _passWord)
        {
            if (_userName == this.userName && _passWord == this.passWord)
            {
                Console.WriteLine("Istifadecinin Detallari");
                Console.WriteLine();
                Console.WriteLine("Istifadecinin Adi ve Soyadi:{0}  \nKart Nomresi:{1} \nExpire Date:{2} \nCvc:{3} \nMoney:{3} \nCurrency:{4}", nameSurName, cardNumber, expireDate, cvc, Money, currency);
                Console.WriteLine();
                Console.WriteLine("Yeni Kart Yaratmaq Isiyirsiniz?(y/n)");
                string qerar = Console.ReadLine();

                if (qerar == "y")
                {
                    Console.WriteLine("Kimin Ucun Yaratnaq Isteyirsinizse Hemin Sexsin Adini ve Soyadini Yazin");
                    string yeniSexs = Console.ReadLine();
                    Label:
                    Console.WriteLine("Yatiracaqiniz Meblegi Yazin");
                    int money = Convert.ToInt32(Console.ReadLine());

                    if (money > 50000)
                    {
                        Console.WriteLine("Hesabdaki eblegden Artiq Pul Yatirila Bilmez");
                        goto Label;
                    }
                    else
                    {

                        Label2:

                        Console.WriteLine("Etibarliliq Muddeti: (10 - ilden Cox Ola Bilmez)");

                        int etibarliliqMuddeti = Convert.ToInt32(Console.ReadLine());

                        if (etibarliliqMuddeti > 10)
                        {
                            Console.WriteLine("Etibarliliq Muddeti 10 il -den Cox Ola Bilmez");
                            goto Label2;
                        }
                        else
                        {
                          
                        }
                    }
                }
            }

        }

    }
}