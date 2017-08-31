using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__dbgcastclass_ldarg__dbgcastclass_ldarg_
    {
        [Fact]
        public void _casts_coverage__dbgcastclass_ldarg__dbgcastclass_ldarg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_dbgcastclass_ldarg\\_dbgcastclass_ldarg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
