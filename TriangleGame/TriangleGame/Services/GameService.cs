using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleGame.Services
{
    public class GameService : IGameService
    {
        public string GetNewGameToken()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            return random.Next().ToString();
        }
    }
}
