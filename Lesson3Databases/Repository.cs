using System;
using System.Collections.Generic;
using System.Data;
using ServiceStack.OrmLite;

namespace Lesson3Databases {
    class Repository : IDisposable {
        const string ConnectionString = @"server=.\sql14;database=ManaOverflow;Integrated Security=true;";
        readonly IDbConnection _db;

        public Repository() {
            _db = new OrmLiteConnectionFactory(ConnectionString, SqlServerDialect.Provider).Open();
        }

        public List<Card> GetAllCards() {
            return _db.Select<Card>();
        }

        public void AddCard(Card card) {
            _db.Save(card);
        }

        public void Dispose() {
            if (_db != null) 
                _db.Dispose();
        }
    }
}
