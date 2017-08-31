using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__speed_relisinst_ldarg__speed_relisinst_ldarg_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__speed_relisinst_ldarg__speed_relisinst_ldarg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_relisinst_ldarg\\_speed_relisinst_ldarg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
