using System;

namespace IT.Signing;

public interface IRawSignatureVerifier
{
    Boolean Verify(Byte[] rawSignature, Byte[] hash, Byte[] certificate);
}