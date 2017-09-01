using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_ExchangeTClass_ExchangeTClass_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_ExchangeTClass_ExchangeTClass_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\ExchangeTClass\\ExchangeTClass.cmd");
        }
    }
}
