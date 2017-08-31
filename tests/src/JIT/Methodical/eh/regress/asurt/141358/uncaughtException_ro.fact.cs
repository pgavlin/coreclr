using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_regress_asurt_141358_uncaughtException_ro_uncaughtException_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_regress_asurt_141358_uncaughtException_ro_uncaughtException_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\regress\\asurt\\141358\\uncaughtException_ro\\uncaughtException_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
