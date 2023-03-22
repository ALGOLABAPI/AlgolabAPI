using System;
using System.Collections.Generic;
using System.Text;

namespace AlgolabAPI
{
    [Serializable]
    public class WebsocketData
    {
        public string Type { get; set; }
        public object Content { get; set; }

    }
    [Serializable]
    public class Depth
    {
        public string Symbol { get; set; } //Sembol
        public string Market { get; set; } //VIP veya IMKBH veya FX gibi market bilgisi
        public string Direction { get; set; } //Yön
        public int Row { get; set; } //Satır
        public int Quantity { get; set; } //Lot Miktarı
        public double Price { get; set; } //Fiyat
        public int OrderCount { get; set; } //Emir Miktarı
        public DateTime Date { get; set; } //Güncellenme tarihi

    }

    [Serializable]
    public class Tick
    {
        public string Symbol { get; set; } //Sembol
        public string Market { get; set; } //VIP veya IMKBH veya FX gibi market bilgisi
        public double Price { get; set; } //Fiyat
        public double Change { get; set; }//Dünkü kapanış fiyatına göre değişim fiyatı
        public double Ask { get; set; } //Satış Fiyatı
        public double Bid { get; set; } //Alış Fiyatı
        public DateTime Date { get; set; } //İşlem Saati
        public double ChangePercentage { get; set; }//Dünkü kapanış fiyatına göre değişim yüzdesi
        public double High { get; set; } //Günlük En Yüksek Fiyat
        public double Low { get; set; } // Günlük En Düşük Fiyat
        public double TradeQuantity { get; set; } //İşlem Lot
        public string Direction { get; set; }// Yön
        public double RefPrice { get; set; } //Baz Fiyat
        public double BalancePrice { get; set; } //Denge Fiyatı
        public double BalanceAmount { get; set; } //Denge Miktarı
        public string Buying { get; set; } //Alan
        public string Selling { get; set; } //Satan
    }

}
