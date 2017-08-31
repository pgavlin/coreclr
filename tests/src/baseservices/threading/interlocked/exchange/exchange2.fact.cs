using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_exchange_exchange2_exchange2_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchange2_exchange2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchange2\\exchange2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
