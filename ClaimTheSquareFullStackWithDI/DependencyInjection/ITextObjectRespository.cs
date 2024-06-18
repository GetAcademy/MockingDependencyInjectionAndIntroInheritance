using ClaimTheSquareFullStack.Model;

namespace ClaimTheSquareFullStackWithDI.DependencyInjection
{
    interface ITextObjectRespository
    {
        Task<IEnumerable<TextObject>> ReadAll();
        Task<bool> Create(TextObject textObject);
    }
}
