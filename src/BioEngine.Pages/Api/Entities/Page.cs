using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BioEngine.Core.API.Entities;
using BioEngine.Core.API.Models;

namespace BioEngine.Pages.Api.Entities
{
    public class Page : SiteEntityRestModel<Pages.Entities.Page>,
        IContentRequestRestModel<Pages.Entities.Page>,
        IContentResponseRestModel<Pages.Entities.Page>
    {
        public List<ContentBlock> Blocks { get; set; }

        public async Task<Pages.Entities.Page> GetEntityAsync(Pages.Entities.Page entity)
        {
            entity = await FillEntityAsync(entity);
            return entity;
        }

        public async Task SetEntityAsync(Pages.Entities.Page entity)
        {
            await ParseEntityAsync(entity);
            Blocks = entity.Blocks?.Select(ContentBlock.Create).ToList();
        }
    }
}
