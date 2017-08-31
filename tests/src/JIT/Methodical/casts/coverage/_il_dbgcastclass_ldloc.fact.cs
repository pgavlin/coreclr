using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_dbgcastclass_ldloc__il_dbgcastclass_ldloc_
    {
        [Fact]
        public void _casts_coverage__il_dbgcastclass_ldloc__il_dbgcastclass_ldloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_dbgcastclass_ldloc\\_il_dbgcastclass_ldloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
