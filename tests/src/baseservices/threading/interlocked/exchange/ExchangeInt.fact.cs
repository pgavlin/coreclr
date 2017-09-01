using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_ExchangeInt_ExchangeInt_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_ExchangeInt_ExchangeInt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\ExchangeInt\\ExchangeInt.cmd");
        }
    }
}
