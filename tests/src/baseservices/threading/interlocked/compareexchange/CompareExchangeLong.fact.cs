using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_compareexchange_CompareExchangeLong_CompareExchangeLong_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_CompareExchangeLong_CompareExchangeLong_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\CompareExchangeLong\\CompareExchangeLong.cmd");
        }
    }
}
