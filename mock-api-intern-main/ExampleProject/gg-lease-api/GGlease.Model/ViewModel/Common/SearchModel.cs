namespace GGlease.Model.ViewModel
{
    public class SearchModel
    {
        private int _pageNo;
        private int _pageSize;
        
        public int PageNo
        {
            get { return _pageNo; }
            set { _pageNo = Math.Max(value, 1); }
        }

        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value == -1 ? value : Math.Max(value, 1); }
        }

        public int RowIndex => (PageNo - 1) * PageSize;
    }
}