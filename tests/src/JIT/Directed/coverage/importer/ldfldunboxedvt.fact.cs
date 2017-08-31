using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_ldfldunboxedvt_ldfldunboxedvt_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_ldfldunboxedvt_ldfldunboxedvt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\ldfldunboxedvt\\ldfldunboxedvt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
