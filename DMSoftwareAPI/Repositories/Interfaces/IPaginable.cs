using DMSoftwareAPI.Models;
using System.Collections.Generic;

namespace DMSoftwareAPI.Repositories.Interfaces
{
    public interface IPaginable<T>
    {
        IEnumerable<T> GetElements(Pagination data);
    }
}
