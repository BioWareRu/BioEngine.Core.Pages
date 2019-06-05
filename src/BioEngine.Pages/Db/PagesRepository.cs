using System.Linq;
using BioEngine.Core.Repository;
using BioEngine.Pages.Entities;
using Microsoft.EntityFrameworkCore;

namespace BioEngine.Pages.Db
{
    public class PagesRepository : ContentEntityRepository<Page>
    {
        protected override IQueryable<Page> GetBaseQuery()
        {
            return DbContext.Set<Page>().Include(p => p.Blocks);
        }

        public PagesRepository(BioRepositoryContext<Page> repositoryContext) : base(repositoryContext)
        {
        }
    }
}
