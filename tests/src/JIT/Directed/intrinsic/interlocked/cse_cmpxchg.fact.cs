using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_interlocked_cse_cmpxchg_cse_cmpxchg_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_cse_cmpxchg_cse_cmpxchg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\cse_cmpxchg\\cse_cmpxchg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
