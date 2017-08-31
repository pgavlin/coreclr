using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_regress_asurt_141358_uncaughtException_r_uncaughtException_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_regress_asurt_141358_uncaughtException_r_uncaughtException_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\regress\\asurt\\141358\\uncaughtException_r\\uncaughtException_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
