using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_interlocked_regalloc2_regalloc2_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_regalloc2_regalloc2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\regalloc2\\regalloc2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
