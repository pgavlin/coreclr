using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_compareexchange_CompareExchangeTString_CompareExchangeTString_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_CompareExchangeTString_CompareExchangeTString_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\CompareExchangeTString\\CompareExchangeTString.cmd");
        }
    }
}
