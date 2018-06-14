using System.Collections.Generic;

namespace LivrariaMVC.JqGrid
{
    public class JqGrid
    {
        public string url { get; set; }
        public string datatype { get; set; }
        public string pager { get; set; }
        public string gridComplete { get; set; }
        public string onSelectRow { get; set; }
        public List<ColModel> colModel { get; set; }
        public string editurl { get; set; }
        public bool loadonce { get; set; } = true;

        public JqGrid(string url, string datatype, string pager, string gridComplete, string onSelectRow, List<ColModel> colModel, string editurl = null)
        {
            this.url = url;
            this.datatype = datatype;
            this.pager = pager;
            this.colModel = colModel;
            this.gridComplete = gridComplete;
            this.onSelectRow = onSelectRow;
            this.editurl = editurl;
        }
    }
}
