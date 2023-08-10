using AutoMapper;
using blogers.Application.Contracts.Persitence;
using MediatR;
using bloger = blogers.Domain.Blogger;

namespace blogers.Application.Features.Bloger.Command.AddBloger
{
	public class AddBlogerCommandHandler:IRequestHandler<AddBlogerCommand,int>
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		public AddBlogerCommandHandler(IUnitOfWork unitOfWork,IMapper mapper)
		{
			this._unitOfWork = unitOfWork;
			this._mapper = mapper;
		}

        public async Task<int> Handle(AddBlogerCommand request, CancellationToken cancellationToken)
        {
			var data = _mapper.Map<bloger>(request);
			var result = await _unitOfWork.Repository<bloger>().AddAsync(data);
			return result.Id;
        }
    }
}

