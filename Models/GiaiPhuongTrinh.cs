namespace Net2Demo.Models
{
    public class GiaiPhuongTrinh
    { 
      //Phuong thuc giai phuong trinh bac nhat
      public string GiaiPhuongTrinhBacNhat(strinh heSoA, string heSoB)
      {
        double a, b, x;
        string ThongBao;
        a = Convert.ToDouble(heSoA);
        b = Convert.ToDouble(heSoB);
        if(a==0)
        {
            if(b !=0)
            {
                ThongBao = "Phuong trinh vo nghiem";
            }
            else{
                ThongBao = "Phuong trinh co vo so nghiem";
            }
        }
        else{
            x = -b/a;
            ThongBao = " Phuong trinh co nghiem x =" + x;
        }
        
      }
      //Phuong thuc giai phuong trinh bac 2
      public string GiaiPhuongTrinhBacHai(string heSoA, string heSoB,string heSoC)
      {
        double a, b, c, delta, x1, x2;
        string ThongBao;
        a = Convert.ToDouble(heSoA);
        b = Convert.ToDouble(heSoB);
        c = Convert.ToDouble(heSoC);
        delta = b * b - 4 * a *c;
        if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        ThongBao = "Phuong trinh co vo so nghiem.";
                        
                    }
                    else
                    {
                        ThongBao = "Phuong trinh vo nghiem.";
                    }
                }
                else
                {
                    x1 = (double)-c / b;
                    ThongBao = " Phuong trinh co mot nghiem x =" + Math.Round(x1, 2);
                }
            }
            else
            //kiem tra delta < 0 thi phuong trinh vo nghiem:
                if (delta < 0)
                {
                     ThongBao = "Phuong trinh vo nghiem.";
                }
            //neu delta = 0 thi phuong trinh co hai nghiem kep:
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    ThongBao = "Phuong trinh co nghiem kep x1 = x2 = " + x1;
                }
            //neu delta > 0 thi phuong trinh co hai nghiem phan biet:
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    ThongBao = "Phuong trinh co hai nghiem phan biet:X1 = " + x1 + " va " + "X2 = " + x2;
                }
            }
        return View();
        
    }
}