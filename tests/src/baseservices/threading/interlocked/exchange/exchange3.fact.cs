using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_exchange_exchange3_exchange3_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchange3_exchange3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchange3\\exchange3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
