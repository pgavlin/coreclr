using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__speed_dbgcastclass_ldarg__speed_dbgcastclass_ldarg_
    {
        [Fact]
        public void _casts_coverage__speed_dbgcastclass_ldarg__speed_dbgcastclass_ldarg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_dbgcastclass_ldarg\\_speed_dbgcastclass_ldarg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
