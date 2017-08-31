using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_CompareExchangeTClass_1_CompareExchangeTClass_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_CompareExchangeTClass_1_CompareExchangeTClass_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\CompareExchangeTClass_1\\CompareExchangeTClass_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
