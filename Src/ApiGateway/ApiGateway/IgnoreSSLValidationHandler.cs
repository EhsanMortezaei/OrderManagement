public class IgnoreSSLValidationHandler : DelegatingHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        HttpClientHandler clientHandler = new()
        {
            ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
        };
        return base.SendAsync(request, cancellationToken);
    }
}