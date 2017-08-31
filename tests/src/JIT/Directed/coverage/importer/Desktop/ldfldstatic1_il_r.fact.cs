using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_Desktop_ldfldstatic1_il_r_ldfldstatic1_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_Desktop_ldfldstatic1_il_r_ldfldstatic1_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\Desktop\\ldfldstatic1_il_r\\ldfldstatic1_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
