using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_CompareExchangeTClass_CompareExchangeTClass_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_CompareExchangeTClass_CompareExchangeTClass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\CompareExchangeTClass\\CompareExchangeTClass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
