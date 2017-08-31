using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_relisinst_ldarg__il_relisinst_ldarg_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__il_relisinst_ldarg__il_relisinst_ldarg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_relisinst_ldarg\\_il_relisinst_ldarg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
