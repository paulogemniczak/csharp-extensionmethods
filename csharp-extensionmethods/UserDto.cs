namespace csharp_extensionmethods
{
	internal class UserDto
	{
		public int UserId { get; set; }
		public string UserName { get; set; } = string.Empty;
		public string UserEmail { get; set; } = string.Empty;
		public string UserPassword { get; set; } = string.Empty;

		public void Print()
		{
			Console.WriteLine(
				$"UserId: {UserId}\n" +
				$"UserName: {UserName}\n" +
				$"UserEmail: {UserEmail}\n" +
				$"UserPassword: {UserPassword}\n"
			);
		}
	}
}
