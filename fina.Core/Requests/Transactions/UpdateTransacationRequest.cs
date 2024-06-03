using System.ComponentModel.DataAnnotations;
using fina.Core.Enums;

namespace fina.Core.Requests.Transactions;


public class UpdateTransactionRequest : Request{ 

    [Required(ErrorMessage = "Título invalido")]
    public string Title {get; set;} = string.Empty;

    [Required(ErrorMessage = "Tipo inválido")]
    public ETransactionType Type {get; set;} = ETransactionType.without;

    [Required(ErrorMessage = "Valor inválido")]
    public decimal Amount { get; set;}

    [Required(ErrorMessage ="Categoria inválida")]
    public long CategoryId { get; set;}

    [Required(ErrorMessage = "Data invalida")]
    public DateTime? PairOrReceivedAt {get; set;}
}