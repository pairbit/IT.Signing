namespace IT.Signing.Models;

public enum SignatureFaultType
{
    UnknownDigestAlgorithm,
    UnknownSignatureAlgorithm,
    SignerCertificateNotFound,
    SignerCertificateIssuerNotFound,
    SignerCertificateSignatureInvalid,
    SignerCertificateCRLNotFound,
    SignerCertificateExpired,
    SignerCertificateRevoked,
    InvalidDigestValue,
    InvalidSignatureValue,
    InvalidSignatureTimeStamp,
}