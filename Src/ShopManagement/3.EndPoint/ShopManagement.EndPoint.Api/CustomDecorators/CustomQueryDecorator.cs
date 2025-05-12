using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;

namespace ShopManagement.EndPoint.Api.CustomDecorators;

public sealed class CustomQueryDecorator : QueryDispatcherDecorator
{
    public override int Order => 0;

    public override async Task<QueryResult<TData>> Execute<TQuery, TData>(TQuery query)
    {
        return await _queryDispatcher.Execute<TQuery, TData>(query);
    }
}