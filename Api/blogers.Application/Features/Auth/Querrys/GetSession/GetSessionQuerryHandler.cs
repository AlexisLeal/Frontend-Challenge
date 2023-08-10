using blogers.Application.Contracts.Persitence;
using MediatR;
using auth = blogers.Domain.Auth;

namespace blogers.Application.Features.Auth.Querrys.GetSession
{
	public class GetSessionQuerryHandler:IRequestHandler<GetSessionQuerry, bool>
	{
        private readonly IUnitOfWork _unitOfWorok;
		public GetSessionQuerryHandler(IUnitOfWork unitOfWork)
		{
            this._unitOfWorok = unitOfWork;
		}

        public async Task<bool> Handle(GetSessionQuerry request, CancellationToken cancellationToken)
        {
            string user = request.userName.Trim().ToUpper();
            var data = await _unitOfWorok.Repository<auth>().GetAsync(x=>x.Username.ToUpper().Equals(user));
            var result = data.FirstOrDefault();
            if (result == null) return false;
            if (!result.Pass.Equals(request.password)) return false;
            return true;
        }
    }
}

