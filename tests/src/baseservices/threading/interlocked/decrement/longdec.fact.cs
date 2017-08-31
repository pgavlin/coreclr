using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_decrement_longdec_longdec_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_decrement_longdec_longdec_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\decrement\\longdec\\longdec.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
