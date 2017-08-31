using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__speed_relisinst_ldloc__speed_relisinst_ldloc_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__speed_relisinst_ldloc__speed_relisinst_ldloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_relisinst_ldloc\\_speed_relisinst_ldloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
