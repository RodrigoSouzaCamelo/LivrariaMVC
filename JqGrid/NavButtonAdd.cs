namespace LivrariaMVC.JqGrid
{
    public class NavButtonAdd
    {
        public string caption { get { return ""; } }
        public string title { get; set; }
        public string id { get; set; }
        public string buttonicon { get; set; }
        public string onClickButton { get; set; }

        public NavButtonAdd(string title, string id, string buttonicon, string onClickButton)
        {
            this.title = title;
            this.id = id;
            this.buttonicon = buttonicon;
            this.onClickButton = onClickButton;
        }
    }
}
