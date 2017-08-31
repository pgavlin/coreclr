using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__relisinst_ldloc__relisinst_ldloc_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__relisinst_ldloc__relisinst_ldloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_relisinst_ldloc\\_relisinst_ldloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
