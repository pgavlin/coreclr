using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_dbgisinst_ldarg__il_dbgisinst_ldarg_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__il_dbgisinst_ldarg__il_dbgisinst_ldarg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_dbgisinst_ldarg\\_il_dbgisinst_ldarg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
