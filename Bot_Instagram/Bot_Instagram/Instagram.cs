using System;
using System.Collections.Generic;
using System.Text;

namespace Bot_Instagram
{
    public static class Instagram
    {
        public static Profile GetProfileByUser(string username)
        {
            var profile = new Profile(username);
            string url = @"https://www.instagram.com/"+username"/";
        }
    }
}
