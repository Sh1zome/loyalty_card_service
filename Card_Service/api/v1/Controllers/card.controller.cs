namespace CardService.api.v1.Controllers;

using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/v1/cards")]
public class CardController : ControllerBase
{
    private readonly Services.CardService _cardService;

    public CardController(Services.CardService cardService)
    {
        _cardService = cardService;
    }
}