using System.Linq.Expressions;
using GGlease.Model.ViewModel;

namespace GGlease.Services.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> source, bool condition, Expression<Func<TSource, bool>> predicate)
        {
            if (condition)
                return source.Where(predicate);

            return source;
        }

        public static IQueryable<TSource> Paginate<TSource>(this IQueryable<TSource> source, SearchModel model)
        {
            if (model.PageSize != -1)
                return source.Skip(model.RowIndex).Take(model.PageSize);

            return source;
        }
    }
}
