using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleGame.Services
{
    public interface IShareService
    {
        Task<bool> ShareUrl(string url);
    }
}
