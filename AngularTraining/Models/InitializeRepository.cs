namespace AngularStart.Models
{
    using System.Web;

    public static class InitializeRepository
    {
        private const string RepositoryName = "Repository";
        public static Repository GetRepository()
        {
            if (HttpContext.Current.Session.IsNewSession)
            {
                var db = new Repository();
                HttpContext.Current.Session[RepositoryName] = db;
                return db;
            }
            var currentDb = HttpContext.Current.Session[RepositoryName] as Repository;
            return currentDb;
        }
    }
}