using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_exchange_ExchangeTString_1_ExchangeTString_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_ExchangeTString_1_ExchangeTString_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\ExchangeTString_1\\ExchangeTString_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
