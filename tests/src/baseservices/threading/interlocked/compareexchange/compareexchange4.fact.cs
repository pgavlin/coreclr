using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_compareexchange4_compareexchange4_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchange4_compareexchange4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchange4\\compareexchange4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
