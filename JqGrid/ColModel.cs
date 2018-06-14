namespace LivrariaMVC.JqGrid
{
    public class ColModel
    {
        public string label { get; set; }
        public string name { get; set; }
        public string index { get; set; }
        public string width { get; set; }
        public string align { get; set; }
        public string formatter { get; set; }
        public bool key { get; set; }
        public bool sortable { get; set; } = true;
        public bool search { get; set; } = true;
        public bool hidden { get; set; }
        public bool editable { get; set; } = false;
        public editrulesNumber editrules { get; set; }
        public formatOptions formatoptions { get; set; }

        public class editrulesNumber
        {
            public bool number { get; set; }
            public bool custom { get; set; }
            public string custom_func { get; set; }
            public bool required { get; set; } = true;
        }

        public class formatOptions
        {
            public string srcformat { get; set; }
            public string decimalSeparator { get; set; }
            public int decimalPlaces { get; set; }
            public string suffix { get; set; }
            public string thousandsSeparator { get; set; }
            public string prefix { get; set; }
        }
    }
}