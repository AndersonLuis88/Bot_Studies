using System;

namespace Bot_Instagram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Perfil a exibir:");
            string user = Console.ReadLine();
            Profile profile = Instagram.GetProfileByUser(user);

            Console.WriteLine($"UserName = {profile.UserName}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Title = {profile.Title}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Description = {profile.Description}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Url = {profile.Url}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Image = {profile.Image}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"AndroidAppId = {profile.AndroidAppId}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"AndroidAppNamee = {profile.AndroidAppName}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"AndroidUrl = {profile.AndroidUrl}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"IosAppId = {profile.IosAppId}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"IosAppName = {profile.IosAppName}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"IosUrl = {profile.IosUrl}");
            Console.WriteLine("---------------------");
            
            Console.ReadKey();
        }
    }
}
