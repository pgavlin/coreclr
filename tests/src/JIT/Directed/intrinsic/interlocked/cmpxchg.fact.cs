using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_interlocked_cmpxchg_cmpxchg_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_cmpxchg_cmpxchg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\cmpxchg\\cmpxchg.cmd");
        }
    }
}
