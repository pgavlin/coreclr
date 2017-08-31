using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_CompareExchangeLong_2_CompareExchangeLong_2_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_CompareExchangeLong_2_CompareExchangeLong_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\CompareExchangeLong_2\\CompareExchangeLong_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
