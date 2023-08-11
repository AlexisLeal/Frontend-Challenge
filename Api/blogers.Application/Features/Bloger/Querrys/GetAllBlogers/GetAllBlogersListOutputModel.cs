namespace blogers.Application.Features.Bloger.Querrys.GetAllBlogers
{
	public class GetAllBlogersListOutputModel
	{
		public string Name { get; set; }
        public string Website { get; set; }
		public string Picture { get; set; }

        public GetAllBlogersListOutputModel(string name, string website, string picture)
        {
            Name = name;
            Website = website;
            Picture = picture;
        }
    }
}

    