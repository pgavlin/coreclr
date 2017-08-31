using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_interlocked_IntrinsicTest_Overflow_IntrinsicTest_Overflow_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_IntrinsicTest_Overflow_IntrinsicTest_Overflow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\IntrinsicTest_Overflow\\IntrinsicTest_Overflow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
