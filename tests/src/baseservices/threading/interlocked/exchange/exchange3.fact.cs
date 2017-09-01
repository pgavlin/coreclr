using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_exchange3_exchange3_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchange3_exchange3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchange3\\exchange3.cmd");
        }
    }
}
