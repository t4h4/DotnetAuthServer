using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAuthServer.Core.UnitOfWork
{
    // Detail: https://www.t4h4.net/wp-content/uploads/2021/07/218166515286125165320.png
    public interface IUnitOfWork
    {
        Task CommmitAsync();

        void Commit();
    }
}
