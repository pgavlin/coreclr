using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_Desktop_refanytype1_il_r_refanytype1_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_Desktop_refanytype1_il_r_refanytype1_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\Desktop\\refanytype1_il_r\\refanytype1_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
