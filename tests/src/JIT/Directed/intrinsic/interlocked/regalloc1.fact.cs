using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_interlocked_regalloc1_regalloc1_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_regalloc1_regalloc1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\regalloc1\\regalloc1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
