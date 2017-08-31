using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_stfldstatic1_il_r_stfldstatic1_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_stfldstatic1_il_r_stfldstatic1_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\stfldstatic1_il_r\\stfldstatic1_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
