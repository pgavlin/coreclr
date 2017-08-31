using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_relisinst_ldloc__il_relisinst_ldloc_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__il_relisinst_ldloc__il_relisinst_ldloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_relisinst_ldloc\\_il_relisinst_ldloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
