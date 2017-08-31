using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_CompareExchangeLong_CompareExchangeLong_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_CompareExchangeLong_CompareExchangeLong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\CompareExchangeLong\\CompareExchangeLong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
