namespace GGlease.Model.ViewModel
{
    public class PagedDataModel<T> : SearchModel
    {
        public int PageCount => (int)Math.Ceiling((double)ItemCount / PageSize);
        public int ItemCount { get; set; }
        public IEnumerable<T> Data { get; set; } = null!;
    }
}