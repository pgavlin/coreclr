using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_exchange_ExchangeInt_ExchangeInt_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_ExchangeInt_ExchangeInt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\ExchangeInt\\ExchangeInt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
