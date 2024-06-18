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

        public async Task<bool> Create(TextObject textObject)
        {
            var conn = _sqlConnectionFactory.Create();
            var rowsAffected = await conn.ExecuteAsync("INSERT INTO TextObject VALUES (@Index, @Text, @BackColor, @ForeColor)",
                textObject);
            return rowsAffected == 1;
        }
    }
}
