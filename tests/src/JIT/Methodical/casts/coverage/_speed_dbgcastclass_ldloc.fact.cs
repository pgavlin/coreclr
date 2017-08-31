using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__speed_dbgcastclass_ldloc__speed_dbgcastclass_ldloc_
    {
        [Fact]
        public void _casts_coverage__speed_dbgcastclass_ldloc__speed_dbgcastclass_ldloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_dbgcastclass_ldloc\\_speed_dbgcastclass_ldloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
