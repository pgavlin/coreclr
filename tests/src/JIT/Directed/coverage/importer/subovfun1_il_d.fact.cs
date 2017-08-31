using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_subovfun1_il_d_subovfun1_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_subovfun1_il_d_subovfun1_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\subovfun1_il_d\\subovfun1_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
