using System;
using System.Threading;
using System.Threading.Tasks;

namespace Companies.SystemTests
{
    public interface ISystemTestCase
    {
        TestClient Client { get; set; }
        Task Given();
        Task When();
        Task Then();
    }
}