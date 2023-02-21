using IT.Signing.Models;

namespace IT.Signing;

public interface ISignatureVerifier : IAsyncSignatureVerifier
{
    bool Verify(string signature, string? detachedData = null);

    Signatures VerifyDetail(string signature, string? detachedData = null);
}