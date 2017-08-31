using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__dbgcastclass_ldloc__dbgcastclass_ldloc_
    {
        [Fact]
        public void _casts_coverage__dbgcastclass_ldloc__dbgcastclass_ldloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_dbgcastclass_ldloc\\_dbgcastclass_ldloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
