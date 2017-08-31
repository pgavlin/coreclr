using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__speed_relcastclass_ldloc__speed_relcastclass_ldloc_
    {
        [Fact]
        public void _casts_coverage__speed_relcastclass_ldloc__speed_relcastclass_ldloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_relcastclass_ldloc\\_speed_relcastclass_ldloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
