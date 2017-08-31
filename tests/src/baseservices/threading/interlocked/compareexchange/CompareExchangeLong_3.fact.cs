using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_CompareExchangeLong_3_CompareExchangeLong_3_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_CompareExchangeLong_3_CompareExchangeLong_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\CompareExchangeLong_3\\CompareExchangeLong_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
