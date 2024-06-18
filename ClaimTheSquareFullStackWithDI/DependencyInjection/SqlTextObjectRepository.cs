using ClaimTheSquareFullStack.Model;
using Dapper;

namespace ClaimTheSquareFullStackWithDI.DependencyInjection
{
    public class SqlTextObjectRepository : ITextObjectRespository
    {
        private SqlConnectionFactory _sqlConnectionFactory;

        public SqlTextObjectRepository(SqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public async Task<IEnumerable<TextObject>> ReadAll()
        {
            var conn = _sqlConnectionFactory.Create();
            var textobjects = await conn.QueryAsync<TextObject>("SELECT * FROM TextObject");
            return textobjects;
        }

        public Task<bool> Create(TextObject textObject)
        {
            throw new NotImplementedException();
        }
    }
}
