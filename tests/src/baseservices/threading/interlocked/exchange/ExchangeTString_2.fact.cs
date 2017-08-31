using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_exchange_ExchangeTString_2_ExchangeTString_2_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_ExchangeTString_2_ExchangeTString_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\ExchangeTString_2\\ExchangeTString_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
