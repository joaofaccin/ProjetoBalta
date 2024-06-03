using System.Globalization;

namespace fina.Core.Models;

public class Category{
    public long Id { get; set;}
    public string Title { get; set;} = string.Empty;
    public string? Description { get; set;}
    public String UserId { get; set;} = string.Empty;

}