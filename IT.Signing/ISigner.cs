using System;

namespace IT.Signing;

public interface ISigner : IAsyncSigner
{
    String Sign(String alg, String data, String format, Boolean detached);
}