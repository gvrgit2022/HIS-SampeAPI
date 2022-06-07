using MediatR;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using SampleAPI.Application;
using SampleAPI.Application.Test.Model;
using SampleAPI.Infrastructure.Models.Test;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;


namespace SampleAPI.Application.Test.Queries
{ 
public class GetTutorialDataQuery : IRequest<TutorialsTblModelcs>
{
	//Query filter paramters
	[Required]
	public int TutorialId { get; set; }
	
}

	public class GetTutorialDataQueryHandler : BaseHandler, IRequestHandler<GetTutorialDataQuery, TutorialsTblModelcs>
	{
		public GetTutorialDataQueryHandler(testContext tcontext, IMapper mapper) : base(tcontext, mapper) { }

		public async Task<TutorialsTblModelcs> Handle(GetTutorialDataQuery request, CancellationToken cancellationToken)
        {
			//var samples = await testContext.TutorialsTbls.Select
             //  .FirstOrDefaultAsync(cancellationToken);

            var samples = await testContext.TutorialsTbls.AsNoTracking()
                 .Where(c => c.TutorialId == request.TutorialId)
               .ProjectTo<TutorialsTblModelcs>(ConfigurationProvider)
               .FirstOrDefaultAsync(cancellationToken);
            return samples;
		}
	}
}