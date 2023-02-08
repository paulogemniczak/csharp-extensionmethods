using csharp_extensionmethods;

string post = "This is supposed to be a very long blog post blah blah blah...";
string shortenedPost = post.Shorten(5);

Console.WriteLine(shortenedPost);

UserDto userDto = new()
{
	UserId = 1,
	UserName = "Paulo Gemniczak",
	UserEmail = "paulogemniczak@gmail.com",
	UserPassword = "123456789"
};

UserDto? newUser = userDto.WithoutPassword();
newUser?.Print();
