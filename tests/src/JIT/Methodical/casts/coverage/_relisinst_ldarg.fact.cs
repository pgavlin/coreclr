using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__relisinst_ldarg__relisinst_ldarg_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__relisinst_ldarg__relisinst_ldarg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_relisinst_ldarg\\_relisinst_ldarg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
