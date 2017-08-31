using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_exchange_exchange4_exchange4_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchange4_exchange4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchange4\\exchange4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
