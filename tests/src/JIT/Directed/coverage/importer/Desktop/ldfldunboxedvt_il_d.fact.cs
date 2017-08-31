using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_Desktop_ldfldunboxedvt_il_d_ldfldunboxedvt_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_Desktop_ldfldunboxedvt_il_d_ldfldunboxedvt_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\Desktop\\ldfldunboxedvt_il_d\\ldfldunboxedvt_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
