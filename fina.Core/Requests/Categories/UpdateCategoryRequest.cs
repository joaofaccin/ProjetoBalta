using System.ComponentModel.DataAnnotations;

namespace fina.Core.Requests.Categories;

public class UpdateCategoryRequest : Request{

    public long Id { get; set;}

    [Required(ErrorMessage = "Título inválido")]
    [MaxLength(80, ErrorMessage = "O título deve conter cerca de 80 digitos")]
    public string Title {get; set;} = string.Empty;

    [Required(ErrorMessage = "Descrição Inválida")]
    public string Description {get; set;} = string.Empty;
}