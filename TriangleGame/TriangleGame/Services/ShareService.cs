using Plugin.Share;
using Plugin.Share.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleGame.Services
{
    public class ShareService : IShareService
    {
        public Task<bool> ShareUrl(string url)
        {
            return CrossShare.Current.Share(new ShareMessage()
            {
                Url = url,
                Text = "Join the Triangle Game!",
                Title = "The Triangle Game"
            });
        }
    }
}
