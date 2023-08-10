using AutoMapper;
using blogers.Application.Contracts.Persitence;
using MediatR;
using bloger = blogers.Domain.Blogger;


namespace blogers.Application.Features.Bloger.Querrys.GetBlogerById
{
    public class GetBlogerByIdQuerryHandler:IRequestHandler<GetBlogerByIdQuerry, GetBlogersByIdQuerryOutputModel>
	{
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBlogerByIdQuerryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

      
        public async Task<GetBlogersByIdQuerryOutputModel> Handle(GetBlogerByIdQuerry request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.Repository<bloger>().GetByIdAsync(request.id);
            return _mapper.Map<GetBlogersByIdQuerryOutputModel>(data);
        }
    }
}

