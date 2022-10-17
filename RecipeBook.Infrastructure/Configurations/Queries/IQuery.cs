using MediatR;

namespace RecipeBook.Infrastructure.Configurations.Queries
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {

    }
}
