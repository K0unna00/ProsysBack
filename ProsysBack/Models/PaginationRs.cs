namespace ProsysBack.Models;

public class PaginationRs<T>
{
    public int TotalCount { get; set; }

    public List<T> Response { get; set; }
}
