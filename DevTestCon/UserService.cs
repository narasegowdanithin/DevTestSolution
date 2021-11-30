using System;
using System.Collections.Generic;
using Wescale.DevTestCommon;
using Wescale.DevTestData;

namespace Wescale.DevTestCon {

    /// <summary>
    /// User service.
    /// </summary>
    public class UserService : MarshalByRefObject, IUserService {

        /// <summary>
        /// Load user.
        /// </summary>
        public User Get(int id) {
            return (new UserDalc()).Get(id);
        }

        /// <summary>
        /// Save user.
        /// </summary>
        public int Save(User user) {
            return (new UserDalc()).Save(user);
        }

        /// <summary>
        /// Save or update user.
        /// </summary>
        public void SaveOrUpdate(User user) {
            (new UserDalc()).SaveOrUpdate(user);
        }

        /// <summary>
        /// Retrieve <see cref="User"/> page wise.
        /// </summary>
        /// <param name="pageIndex">Index of page</param>
        /// <param name="pageSize">Size of page</param>
        /// <param name="totalRecords">Total count of users.</param>
        public IList<User> List(int pageIndex, int pageSize, out int totalRecords) {
            return (new UserDalc()).List(pageIndex, pageSize, out totalRecords);
        }

    }
}
