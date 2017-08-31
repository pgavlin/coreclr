using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_exchange_exchange4_cti_exchange4_cti_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchange4_cti_exchange4_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchange4_cti\\exchange4_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
