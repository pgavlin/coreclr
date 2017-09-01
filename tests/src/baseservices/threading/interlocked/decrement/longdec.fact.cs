using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_decrement_longdec_longdec_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_decrement_longdec_longdec_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\decrement\\longdec\\longdec.cmd");
        }
    }
}
