using System.Collections.Generic;

namespace Wescale.DevTestCommon {

    /// <summary>
    /// Interface for user service.
    /// </summary>
    public interface IUserService {

        /// <summary>
        /// Load user.
        /// </summary>
        User Get(int id);

        /// <summary>
        /// Save user.
        /// </summary>
        int Save(User user);

        /// <summary>
        /// Save or update user.
        /// </summary>
        void SaveOrUpdate(User user);

        /// <summary>
        /// Retrieve <see cref="User"/> page wise.
        /// </summary>
        /// <param name="pageIndex">Index of page</param>
        /// <param name="pageSize">Size of page</param>
        /// <param name="totalRecords">Total count of users.</param>
        IList<User> List(int pageIndex, int pageSize, out int totalRecords);

    }
}
