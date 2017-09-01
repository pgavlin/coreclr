using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_interlocked_cse_cmpxchg_cse_cmpxchg_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_cse_cmpxchg_cse_cmpxchg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\cse_cmpxchg\\cse_cmpxchg.cmd");
        }
    }
}
