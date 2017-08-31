using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_exchange_ExchangeLong_ExchangeLong_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_ExchangeLong_ExchangeLong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\ExchangeLong\\ExchangeLong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
