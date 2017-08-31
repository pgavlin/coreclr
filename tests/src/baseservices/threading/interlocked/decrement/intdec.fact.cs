using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_decrement_intdec_intdec_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_decrement_intdec_intdec_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\decrement\\intdec\\intdec.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
