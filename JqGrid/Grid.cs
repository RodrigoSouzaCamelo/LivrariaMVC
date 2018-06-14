using System.Collections.Generic;

namespace LivrariaMVC.JqGrid
{
    public class Grid
    {
        public JqGrid JqGrid { get; set; }
        public NavGrid NavGrid { get; set; }
        public List<NavButtonAdd> NavButtonAdd { get; set; }

        public Grid(JqGrid JqGrid, NavGrid NavGrid, List<NavButtonAdd> NavButtonAdd)
        {
            this.JqGrid = JqGrid;
            this.NavGrid = NavGrid;
            this.NavButtonAdd = NavButtonAdd;
        }
        public Grid(JqGrid JqGrid, NavGrid NavGrid)
        {
            this.JqGrid = JqGrid;
            this.NavGrid = NavGrid;
        }
    }
}
