using System.Text.Json.Serialization;

namespace fina.Core.Responses;


public  class Response<TData>{

    private int _code = Configuration.DefaultStatusCode;

[JsonConstructor]
    public Response()
    {
        _code = Configuration.DefaultStatusCode;
    }

    public Response(TData? data, int code = Configuration.DefaultStatusCode, string? message = null){
        Data = data;
        _code = code;
        Message  = message;
    }

    public TData? Data {get; set;}
    public string? Message { get; set;}

    [JsonIgnore]
    public bool IsSuccess
{
    get { return _code >= 200 && _code <= 299; }
}

}