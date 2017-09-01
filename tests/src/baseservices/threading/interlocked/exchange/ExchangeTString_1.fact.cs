using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_ExchangeTString_1_ExchangeTString_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_ExchangeTString_1_ExchangeTString_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\ExchangeTString_1\\ExchangeTString_1.cmd");
        }
    }
}
