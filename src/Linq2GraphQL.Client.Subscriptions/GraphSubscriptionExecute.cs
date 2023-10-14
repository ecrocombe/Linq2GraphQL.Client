﻿using System.Linq.Expressions;
using System.Reactive.Linq;

namespace Linq2GraphQL.Client.Subscriptions;

public class GraphSubscriptionExecute<T, TResult> : GraphBaseExecute<T, TResult>
{
    public GraphSubscriptionExecute(GraphClient client, OperationType operationType, QueryNode queryNode,
        Expression<Func<T, TResult>> selector) : base(client, operationType, queryNode, selector) { }

    public async Task<IObservable<TResult>> StartAsync()
    {

        await InitQueryAsync();

        var payload = new GraphRequest
        {
            Query = GetGraphQLQuery(),
            Variables = QueryNode.GetAllActiveArguments().ToDictionary(x => x.GraphName, e => e.Value)
        };

        if (string.IsNullOrWhiteSpace(client.SubscriptionUrl))
        {
            throw new Exception("Subscription url is not set");
        }

        if (client.SubscriptionProtocol == SubscriptionProtocol.ServerSentEvents)
        {
            var sseClient = new SSEClient(client, payload);
#pragma warning disable CS4014
            Task.Run(sseClient.Start);
#pragma warning restore CS4014
            return sseClient.Subscription.Select(e => ConvertResult(queryExecutor.ProcessResponse(e, QueryNode.Alias, payload.Query)));
        }

        var wsClient = new WSClient(client.SubscriptionUrl, client.SubscriptionProtocol, payload);
        await wsClient.Start();
        return wsClient.Subscription.Select(e => ConvertResult(queryExecutor.ProcessResponse(e, QueryNode.Alias, payload.Query)));
    }
}