using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_CompareExchangeTString_CompareExchangeTString_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_CompareExchangeTString_CompareExchangeTString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\CompareExchangeTString\\CompareExchangeTString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
