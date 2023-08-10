using MediatR;

namespace blogers.Application.Features.Bloger.Command.AddBloger
{
	public class AddBlogerCommand: IRequest<int>
	{
      public string name { get; set; }
      public string website { get; set; }
      public string picture_url { get; set; }
      public string email { get; set; }
      public List<int> friends { get; set; }
    }
}

