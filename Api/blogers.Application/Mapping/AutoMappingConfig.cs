namespace blogers.Application.Mapping
{
    public class AutoMappingConfig
	{
		public static Type[] RegisterMappings()
		{
			return new Type[]
			{
				typeof(BlogerProfile),
			};
		}
	}
}

