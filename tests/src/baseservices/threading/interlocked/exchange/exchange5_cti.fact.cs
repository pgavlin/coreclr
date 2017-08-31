using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_exchange_exchange5_cti_exchange5_cti_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchange5_cti_exchange5_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchange5_cti\\exchange5_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
