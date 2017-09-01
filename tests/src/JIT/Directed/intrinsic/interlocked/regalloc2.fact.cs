using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_interlocked_regalloc2_regalloc2_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_regalloc2_regalloc2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\regalloc2\\regalloc2.cmd");
        }
    }
}
