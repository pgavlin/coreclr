using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_interlocked_regalloc1_regalloc1_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_regalloc1_regalloc1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\regalloc1\\regalloc1.cmd");
        }
    }
}
