using System;
using System.Collections.Generic;
using System.Text;

namespace AlgolabAPI
{
    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public dynamic Content { get; set; }
    }
    [Serializable]
    public class Bar
    {
        public double Open { get; set; }
        public double Close { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Amount { get; set; }
        public double Volume { get; set; }
        public DateTime Date { get; set; }
    }
}
