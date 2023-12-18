using System.ComponentModel.DataAnnotations;

namespace CardService.api.v1.models;

public class card
{
    [Key]
    public Guid id = Guid.NewGuid();
    public String number;
    public Boolean isOwned;
    public Boolean isBlocked;
    private int customerId;
    private String createdAt;
    private String releasedAt;
    private String blockedAt;
}