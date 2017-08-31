using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__dbgisinst_ldarg__dbgisinst_ldarg_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__dbgisinst_ldarg__dbgisinst_ldarg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_dbgisinst_ldarg\\_dbgisinst_ldarg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
