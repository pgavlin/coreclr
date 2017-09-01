using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_exchange2_exchange2_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchange2_exchange2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchange2\\exchange2.cmd");
        }
    }
}
