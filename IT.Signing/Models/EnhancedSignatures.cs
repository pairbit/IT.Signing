namespace IT.Signing.Models;

public record EnhancedSignatures
{
    public string? Enhanced { get; set; }

    public Signatures? Signatures { get; set; }
}