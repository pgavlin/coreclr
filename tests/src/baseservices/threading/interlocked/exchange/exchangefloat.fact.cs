using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_exchangefloat_exchangefloat_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchangefloat_exchangefloat_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchangefloat\\exchangefloat.cmd");
        }
    }
}
