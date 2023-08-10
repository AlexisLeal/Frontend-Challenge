using AutoMapper;
using blogers.Application.Features.Bloger.Command.AddBloger;
using blogers.Application.Features.Bloger.Querrys.GetAllBlogers;
using blogers.Application.Features.Bloger.Querrys.GetBlogerById;
using blogers.Domain;

namespace blogers.Application.Mapping
{
    public class BlogerProfile:Profile
	{
		public BlogerProfile()
		{
			AddBlogerCommandToBloger();
			BloggerToBlogerAllList();
			BloggerToBlogerOutputModel();

        }

		public void AddBlogerCommandToBloger()
		{
			CreateMap<AddBlogerCommand, Blogger>()
				.ConstructUsing(scr => new Blogger()
				{
					Name = scr.name,
					Email = scr.email,
					PictureUrl = scr.picture_url,
					Website = scr.website,
					FriendshipBloggers = scr.friends.Select(x => new Friendship()
					{
						FriendId = x
					}).ToList()
				});
		}

		public void BloggerToBlogerAllList()
		{
			CreateMap<Blogger, GetAllBlogersListOutputModel>()
				.ConstructUsing(scr => new GetAllBlogersListOutputModel(scr.Name, scr.Website, scr.PictureUrl));
		}

        public void BloggerToBlogerOutputModel()
        {
            CreateMap<Blogger, GetBlogersByIdQuerryOutputModel>()
                .ConstructUsing(scr =>
				new GetBlogersByIdQuerryOutputModel
				(scr.PictureUrl,
				scr.Name,
				scr.Website,
				scr.FriendshipBloggers.Select(x=>new Friends(x.Friend.Name)).ToList(),
				scr.Email
				));
        }


    }
}

