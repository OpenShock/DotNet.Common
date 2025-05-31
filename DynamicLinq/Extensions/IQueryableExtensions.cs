using OpenShock.DynamicLinq.Query;
using DBExpressionBuilder = OpenShock.DynamicLinq.Query.DBExpressionBuilder;

namespace OpenShock.DynamicLinq.Extensions;

public static class IQueryableExtensions
{
    public static IQueryable<T> ApplyFilter<T>(this IQueryable<T> query, string filterQuery) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filterQuery, nameof(filterQuery));

        return query.Where(DBExpressionBuilder.GetFilterExpression<T>(filterQuery));
    }

    public static IOrderedQueryable<T> ApplyOrderBy<T>(IQueryable<T> query, string orderbyQuery) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(orderbyQuery, nameof(orderbyQuery));

        return OrderByQueryBuilder.ApplyOrderBy(query, orderbyQuery);
    }
}
