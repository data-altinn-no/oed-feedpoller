﻿using Microsoft.Azure.Functions.Worker.Http;

namespace Digdir.Oed.FeedPoller.Interfaces;
public interface IDaEventFeedProxyService
{
    /// <summary>
    /// Proxy function that we use in non-staging environments to access the DA feed which is firewalled
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public Task<HttpResponseData> ProxyRequest(HttpRequestData request);
}
