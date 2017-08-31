using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_regress_asurt_140713_innerFinally_ro_innerFinally_ro_
    {
        [Fact]
        public void _eh_regress_asurt_140713_innerFinally_ro_innerFinally_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\regress\\asurt\\140713\\innerFinally_ro\\innerFinally_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
