namespace GroceryExpress.API.DTO
{
    public class IndexDTO<T>
    {
        public IndexDTO(List<T> results, int page, int size, object filters)
        {
            Results = results;
            Page = page;
            Size = size;
            Filters = filters;
        }

        public List<T> Results { get; set; } = null!;
        public int Page { get; set; }
        public int Size { get; set; }
        public object Filters { get; set; } = null!;
    }
}
