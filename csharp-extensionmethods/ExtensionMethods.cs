namespace csharp_extensionmethods
{
	internal static class ExtensionMethods
	{
		internal static string Shorten(this String str, int numberOfWords)
		{
			if (numberOfWords < 0)
			{
				throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0");
			}

			if (numberOfWords == 0)
			{
				return string.Empty;
			}

			string[] words = str.Split(' ');

			if (words.Length <= numberOfWords)
			{
				return str;
			}

			return string.Join(" ", words.Take(numberOfWords)) + "...";
		}

		public static IEnumerable<UserDto?>? WithoutPasswords(this IEnumerable<UserDto> users)
		{
			if (users == null) return null;

			return users.Select(x => x.WithoutPassword());
		}

		public static UserDto? WithoutPassword(this UserDto user)
		{
			if (user == null) return null;

			user.UserPassword = string.Empty;
			return user;
		}
	}
}
