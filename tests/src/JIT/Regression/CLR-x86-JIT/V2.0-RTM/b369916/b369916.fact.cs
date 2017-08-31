using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V2_0_RTM_b369916_b369916_b369916_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V2_0_RTM_b369916_b369916_b369916_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-RTM\\b369916\\b369916\\b369916.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
