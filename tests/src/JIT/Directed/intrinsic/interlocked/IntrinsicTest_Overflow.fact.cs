using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_interlocked_IntrinsicTest_Overflow_IntrinsicTest_Overflow_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_IntrinsicTest_Overflow_IntrinsicTest_Overflow_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\IntrinsicTest_Overflow\\IntrinsicTest_Overflow.cmd");
        }
    }
}
