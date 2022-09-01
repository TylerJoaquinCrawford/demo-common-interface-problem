
namespace BookPurchaser.Services.MaltesePigeonBooks;

public class MaltesePigeonBooksService
{
    private MaltesePigeonBooksClient _client;

    public MaltesePigeonBooksService(string partnerId, string partnerSecret)
    {
        _client = new MaltesePigeonBooksClient(partnerId, partnerSecret);
    }

    public async Task<BookPurchaseResponse> Purchase(BookPurchaseRequest request)
        => await _client.Books.PurchaseAsync(request);
}