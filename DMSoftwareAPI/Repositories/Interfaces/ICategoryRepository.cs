using DMSoftwareAPI.Models;
using DMSoftwareAPI.Models.Data;
using System;
using System.Collections.Generic;

namespace DMSoftwareAPI.Repositories.Interfaces
{
    public interface ICategoryRepository : IPaginable<Category>
    {
        void AddCategory(Category category);
        void RemoveCategory(Guid id);
    }
}
