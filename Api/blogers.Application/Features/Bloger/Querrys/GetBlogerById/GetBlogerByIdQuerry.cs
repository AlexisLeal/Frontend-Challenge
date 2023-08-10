using MediatR;
namespace blogers.Application.Features.Bloger.Querrys.GetBlogerById
{
    public class GetBlogerByIdQuerry:IRequest<GetBlogersByIdQuerryOutputModel>
	{
		public int id { get; set; }
		public GetBlogerByIdQuerry(int id)
		{
			this.id = id;
		}
	}
}

