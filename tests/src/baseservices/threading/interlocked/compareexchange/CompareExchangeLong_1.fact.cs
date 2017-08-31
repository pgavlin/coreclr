using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_CompareExchangeLong_1_CompareExchangeLong_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_CompareExchangeLong_1_CompareExchangeLong_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\CompareExchangeLong_1\\CompareExchangeLong_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
