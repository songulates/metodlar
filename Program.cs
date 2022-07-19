using System;

namespace metodlar // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim_belirteci geri_donus_tipi metot_adi(argüman/parametre)
            //{
                //komutlar;
            //}
            //iki sayının toplamını veren kod
            int a =3;
            int b=6;
            int sonuc= Topla(a,b); //Console.WriteLine(a+b); //Console.WriteLine(sonuc);
            Metodlar ornek=new Metodlar();//bir instance örnek oluşturduk başka claslara erişmek için// nesne oluşuyo
            ornek.Ekranayazdir(Convert.ToString(sonuc));
            int sonuc2=ornek.Arttirtopla(ref a, ref b);
            ornek.Ekranayazdir(Convert.ToString(sonuc2));
        }
        static int Topla(int deger1,int deger2)
        {
            return(deger1+deger2);

        }
    }
    class Metodlar
    {
        public void Ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int Arttirtopla(ref int deger1, ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }

    }
}