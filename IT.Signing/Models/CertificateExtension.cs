using System;

namespace IT.Signing.Models;

public record CertificateExtension
{
    public String? Oid { get; set; }

    public Boolean? IsCritical { get; set; }

    public String? Value { get; set; }
}