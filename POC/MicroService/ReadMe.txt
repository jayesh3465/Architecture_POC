//Routes

The UpstreamPathTemplate defines the URL of the API Gateway that receives the requests and then redirects to the microservice API (DownstreamPathTemplate).

The UpstreamHttpMethod defines the HTTP Methods (Get, Put, Post, Patch …) that the API Gateway uses to distinguish between the requests.

The DownstreamPathTemplate represents the endpoint at the microservice that is going to receive the request. In other words, it takes the request of the UpstreamPathTemplate and redirects to the DownstreamPathTemplate.

The DownstreamScheme represents the protocol to communicate with the microservice. 

The DownstreamHostAndPorts : defines the URL and the port from the microservices that are going to receive the requests.


//RateLimitOptions

ClientWhitelist - This is an array that contains the whitelist of the client.
It means that the client in this array will not be affected by the rate limiting.

EnableRateLimiting - This value specifies enable endpoint rate limiting.


The second property we need to set up is the Period. Thiproperty defines the specific time window that this rate limit is acting on.

The PeriodTimespan defines the number of seconds we need to wait to request this endpoint after we got the maximum number of requests within the Period. In this case, let’s set its value to 10 seconds.

The last property is the Limit. It defines the maximum number of requests within 10 seconds (Period property).

Once we request this UpstreamPathTemplate (/gateway/articles) more than 3 times within 10 seconds, 
the API Gateway is going to return a Too Many Request (HTTP status 429).

You can also set the following in the GlobalConfiguration part of OcelotRoutes.json

"RateLimitOptions": {
  "DisableRateLimitHeaders": false,
  "QuotaExceededMessage": "Customize Tips!",
  "HttpStatusCode": 999,
  "ClientIdHeader" : "Test"
}
DisableRateLimitHeaders - This value specifies whether X-Rate-Limit and Retry-After headers are disabled.

QuotaExceededMessage - This value specifies the exceeded message.

HttpStatusCode - This value specifies the returned HTTP Status code when rate limiting occurs.

ClientIdHeader - Allows you to specifiy the header that should be used to identify clients. By default it is “ClientId”

//Cache

The TtlSeconds (Time-to-live in seconds) means the time that the Ocelot is going to cache the data. 
After that time, Ocelot is going to discard the cache.

While the data is in the cache, the API Gateway doesn’t make an HTTP request to our microservice. 
That means we are saving resources from our microservice. Once the cache expires, 
the API Gateway requests the microservice once more and saves the data in the cache again.