﻿namespace Tan.Domain.Models;

public class Pagination<T> where T : class
{
    public int CurrentPage { get; set; } = 1;
    public int Count { get; set; }
    public int PageSize { get; set; } = 10;
    public int TotalPages => PageSize > 0 ? (int)Math.Ceiling(Count / (double)PageSize) : 1;
    public List<T> Result { get; set; } = [];
}
