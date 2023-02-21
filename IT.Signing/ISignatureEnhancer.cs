using IT.Signing.Models;
using System;

namespace IT.Signing;

public interface ISignatureEnhancer : IAsyncSignatureEnhancer
{
    String Enhance(String signature, String format, String? detachedData = null);

    EnhancedSignatures EnhanceDetail(String signature, String format, String? detachedData = null);
}