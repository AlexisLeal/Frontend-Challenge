using MediatR;

namespace blogers.Application.Features.Bloger.Querrys.GetAllBlogers
{
	public class GetAllBlogersListQuerrys:IRequest<List<GetAllBlogersListOutputModel>>
	{
		public GetAllBlogersListQuerrys()
		{}
	}
}

