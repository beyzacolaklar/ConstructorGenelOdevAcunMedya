// See https://aka.ms/new-console-template for more information
using System;


class Kapi
{
    public int KapiSayisi { get; set; }
    public Kapi(int kapiSayisi)
    {
        KapiSayisi = kapiSayisi;
    }
}


class Pencere
{
    public int PencereSayisi { get; set; }
    public Pencere(int pencereSayisi)
    {
        PencereSayisi = pencereSayisi;
    }
}


class Kasa
{
    public string KasaTipi { get; set; }
    public Kasa(string kasaTipi)
    {
        KasaTipi = kasaTipi;
    }


    class Marka
    {
        public string MarkaAdi { get; set; }
        public string Model { get; set; }
        public Marka(string markaAdi, string model)
        {
            MarkaAdi = markaAdi;
            Model = model;
        }
    }


    class Araba
    {
        public Marka MarkaBilgisi { get; set; }
        public Kapi KapiBilgisi { get; set; }
        public Pencere PencereBilgisi { get; set; }
        public Kasa KasaBilgisi { get; set; }
        public decimal Fiyat { get; set; }

        public Araba(Marka marka, Kapi kapi, Pencere pencere, Kasa kasa, decimal fiyat)
        {
            MarkaBilgisi = marka;
            KapiBilgisi = kapi;
            PencereBilgisi = pencere;
            KasaBilgisi = kasa;
            Fiyat = fiyat;
        }

        public void ArabaBilgileriniYazdir()
        {
            Console.WriteLine($"Arabanın markası {MarkaBilgisi.MarkaAdi}, modeli {MarkaBilgisi.Model}, kapı sayısı {KapiBilgisi.KapiSayisi}, pencere sayısı {PencereBilgisi.PencereSayisi}, kasası {KasaBilgisi.KasaTipi}, fiyatı {Fiyat:N0} TL’dir.");
        }
    }

    class Program
    {
        static void Main()
        {
            Marka bmw = new Marka("BMW", "X5");
            Kapi kapi = new Kapi(4);
            Pencere pencere = new Pencere(4);
            Kasa kasa = new Kasa("Sedan");
            decimal fiyat = 2000000m;

            Araba bmwX5 = new Araba(bmw, kapi, pencere, kasa, fiyat);
            bmwX5.ArabaBilgileriniYazdir();
        }
    }
}