using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_compareexchangedouble_compareexchangedouble_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchangedouble_compareexchangedouble_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchangedouble\\compareexchangedouble.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
