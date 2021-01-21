using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Helpers
{

    public class ChartJs
    {
        public string type { get; set; }
        public Data data { get; set; }
        public Options options { get; set; }
    }

    public class Data
    {
        public string[] labels { get; set; }
        public Dataset[] datasets { get; set; }
    }

    public class Dataset
    {
        public string label { get; set; }
        public string[] backgroundColor { get; set; }
        public string borderColor { get; set; }
        public float[] data { get; set; }
    }

    public class Options
    {
        public bool responsive { get; set; }
        public bool maintainAspectRatio { get; set; }
        public Scales scales { get; set; }
        public Title title { get; set; }
        public Legend legend{ get; set; }
        public int cutoutPercentage { get; set; }
    }

    public class Title
    {
        public bool display { get; set; }
        public string text { get; set; }
        public string fontStyle { get; set; }
        public string fontFamily { get; set; }
        public int fontSize { get; set; }
    }

    public class Legend
    {
        public bool display { get; set; }
    }

    public class Scales
    {
        public YAxes[] yAxes { get; set; }
        public XAxes[] xAxes { get; set; }

    }

    public class YAxes
    {
        public bool display { get; set; }
        public Ticks ticks { get; set; }
    }

    public class XAxes
    {
        public bool display { get; set; }
    }

    public class Ticks
    {
        public bool beginAtZero { get; set; }
    }

}
