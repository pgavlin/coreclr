using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_Desktop_ldfldstatic1_il_d_ldfldstatic1_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_Desktop_ldfldstatic1_il_d_ldfldstatic1_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\Desktop\\ldfldstatic1_il_d\\ldfldstatic1_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
