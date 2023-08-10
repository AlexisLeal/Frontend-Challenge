using MediatR;

namespace blogers.Application.Features.Auth.Querrys.GetSession
{
	public class GetSessionQuerry:IRequest<bool>
	{
		public string userName { get;  set; } = string.Empty;

		public string password { get;  set; } = string.Empty;
	}
}

