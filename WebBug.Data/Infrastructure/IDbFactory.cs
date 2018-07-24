using System;

namespace WebBug.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        WebBugDbContext Init();
    }
}