namespace BookPurchaser.Services.MaltesePigeonBooks;

public class BookPurchaseResponse
{

    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public string Status { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("description")]
    public string Description { get; set; }
}