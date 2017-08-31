using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_compareexchangefloat_compareexchangefloat_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchangefloat_compareexchangefloat_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchangefloat\\compareexchangefloat.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
