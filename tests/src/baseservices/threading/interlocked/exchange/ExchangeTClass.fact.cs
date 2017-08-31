using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_exchange_ExchangeTClass_ExchangeTClass_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_ExchangeTClass_ExchangeTClass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\ExchangeTClass\\ExchangeTClass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
