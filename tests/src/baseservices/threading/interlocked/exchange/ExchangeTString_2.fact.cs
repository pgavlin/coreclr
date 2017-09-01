using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_ExchangeTString_2_ExchangeTString_2_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_ExchangeTString_2_ExchangeTString_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\ExchangeTString_2\\ExchangeTString_2.cmd");
        }
    }
}
