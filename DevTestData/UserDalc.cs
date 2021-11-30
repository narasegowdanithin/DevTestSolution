using NHibernate;
using System;
using System.Collections.Generic;
using Wescale.DevTestCommon;

namespace Wescale.DevTestData {

    /// <summary>
    /// Datanbank-Layer für Benutzer.
    /// </summary>
    public class UserDalc : BaseDalc {

        /// <summary>
        /// Load user.
        /// </summary>
        public User Get(int id) {
            ISession session = SessionFactory.OpenSession();
            return session.Get<User>(id);
        }

        /// <summary>
        /// Save user.
        /// </summary>
        public int Save(User user) {
            ISession session = SessionFactory.OpenSession();
            if (user.Version > 0) {
                user.ModifiedOnUtc = DateTime.UtcNow;
            }
            int id = (int)session.Save(user);
            session.Flush();
            return id;
        }

        /// <summary>
        /// Save or update user.
        /// </summary>
        public void SaveOrUpdate(User user) {
            ISession session = SessionFactory.OpenSession();
            if (user.Version > 0) {
                user.ModifiedOnUtc = DateTime.UtcNow;
            }
            session.SaveOrUpdate(user);
            session.Flush();
        }

        /// <summary>
		/// Retrieve <see cref="User"/> page wise.
		/// </summary>
        /// <param name="pageIndex">Index of page</param>
        /// <param name="pageSize">Size of page</param>
        /// <param name="totalRecords">Total count of users.</param>
		public IList<User> List(int pageIndex, int pageSize, out int totalRecords) {
            totalRecords = 42;

            ISession session = SessionFactory.OpenSession();

            ICriteria criteria = session.CreateCriteria<User>();
            criteria.SetFirstResult(pageIndex);
            criteria.SetMaxResults(pageSize);

            return criteria.List<User>();
        }

    }
}
