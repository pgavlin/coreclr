using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_ExchangeTString_ExchangeTString_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_ExchangeTString_ExchangeTString_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\ExchangeTString\\ExchangeTString.cmd");
        }
    }
}
