using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi.Models;

class TransformerComponentHeaders() : IOpenApiDocumentTransformer
{
    public Task TransformAsync(OpenApiDocument document, OpenApiDocumentTransformerContext context, CancellationToken cancellationToken)
    {
        document.Components ??= new OpenApiComponents();
        document.Components.Headers.Add("GenericStringHeader", OpenApiFactory.CreateHeaderString());

        //because of a bug in the spectral OWASP linter, 
        //using the Access-Control-Allow-Origin header instead of `GenericStringHeader`
        //please see https://github.com/stoplightio/spectral-owasp-ruleset/issues/71
        document.Components.Headers.Add("Access-Control-Allow-Origin", OpenApiFactory.CreateHeaderString());

        document.Components.Headers.Add("X-RateLimit-Limit", OpenApiFactory.CreateHeaderInt($"The maximum number of requests you're permitted to make in a window of {GlobalConfiguration.ApiSettings!.FixedWindowRateLimit.Window.Minutes} minutes."));

        return Task.CompletedTask;
    }
}