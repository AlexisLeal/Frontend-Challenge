namespace blogers.Application.Features.Bloger.Querrys.GetBlogerById
{
    public class GetBlogersByIdQuerryOutputModel
	{
        public string picture { get; set; }
        public string name { get; set; }
        public string website { get; set; }
        public List<Friends> friends { get; set; }
        public string email { get; set; }

        public GetBlogersByIdQuerryOutputModel(string picture,
            string name,
            string website,
            List<Friends>friends,
            string email)
        {
            this.picture = picture;
            this.name = name;
            this.website = website;
            this.friends = friends;
            this.email = email;
        }
	}

    public class Friends
    {
        public string Name { get; set; }

        public Friends(string name)
        {
            Name = name;
        }
    }
}

