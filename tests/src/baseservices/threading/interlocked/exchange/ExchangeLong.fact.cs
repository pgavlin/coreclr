using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_ExchangeLong_ExchangeLong_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_ExchangeLong_ExchangeLong_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\ExchangeLong\\ExchangeLong.cmd");
        }
    }
}
