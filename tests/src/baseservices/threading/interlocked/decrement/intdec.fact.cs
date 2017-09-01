using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_decrement_intdec_intdec_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_decrement_intdec_intdec_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\decrement\\intdec\\intdec.cmd");
        }
    }
}
