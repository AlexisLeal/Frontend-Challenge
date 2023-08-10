using AutoMapper;
using blogers.Application.Contracts.Persitence;
using MediatR;
using bloger = blogers.Domain.Blogger;

namespace blogers.Application.Features.Bloger.Querrys.GetAllBlogers
{
    public class GetAllBlogersListHandler:IRequestHandler<GetAllBlogersListQuerrys,List<GetAllBlogersListOutputModel>>
	{
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mediator;

        public GetAllBlogersListHandler(IUnitOfWork unitOfWork, IMapper mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }        

        public async Task<List<GetAllBlogersListOutputModel>> Handle(GetAllBlogersListQuerrys request, CancellationToken cancellationToken)
        {
            var list = await _unitOfWork.Repository<bloger>().GetAllAsync();
            var data = _mediator.Map<List<GetAllBlogersListOutputModel>>(list);
            return data;
        }
    }
}

