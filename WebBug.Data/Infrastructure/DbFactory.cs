namespace WebBug.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private WebBugDbContext dbContext;

        public WebBugDbContext Init()
        {
            return dbContext ?? (dbContext = new WebBugDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}