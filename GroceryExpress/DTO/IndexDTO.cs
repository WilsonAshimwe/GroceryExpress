namespace GroceryExpress.API.DTO
{
    public class IndexDTO<T>
    {
        public IndexDTO(List<T> results, object pagination, object filters)
        {
            Results = results;
            Pagination = pagination;
            Filters = filters;
        }

        public List<T> Results { get; set; } = null!;
        public object Filters { get; set; } = null!;

        public object Pagination { get; set; }
    }
}
