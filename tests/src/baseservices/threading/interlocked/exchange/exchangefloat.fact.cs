using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_exchange_exchangefloat_exchangefloat_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchangefloat_exchangefloat_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchangefloat\\exchangefloat.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
