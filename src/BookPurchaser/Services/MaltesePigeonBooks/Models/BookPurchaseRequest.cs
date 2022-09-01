namespace BookPurchaser.Services.MaltesePigeonBooks;

public class BookPurchaseRequest
{
    [System.Text.Json.Serialization.JsonPropertyName("isbn")]
    public string ISBN { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("purchase_quantity")]
    public int Quantity { get; set; }
}