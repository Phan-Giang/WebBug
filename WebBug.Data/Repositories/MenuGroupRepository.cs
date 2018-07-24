using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBug.Data.Infrastructure;
using WebBug.Model.Models;

namespace WebBug.Data.Repositories
{
    public interface IMenuGroupRepository : IRepository<MenuGroup>
    {
    }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
