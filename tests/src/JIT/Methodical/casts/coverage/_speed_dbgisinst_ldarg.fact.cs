using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__speed_dbgisinst_ldarg__speed_dbgisinst_ldarg_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__speed_dbgisinst_ldarg__speed_dbgisinst_ldarg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_dbgisinst_ldarg\\_speed_dbgisinst_ldarg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
