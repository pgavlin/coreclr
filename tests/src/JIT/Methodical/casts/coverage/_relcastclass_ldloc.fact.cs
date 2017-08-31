using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__relcastclass_ldloc__relcastclass_ldloc_
    {
        [Fact]
        public void _casts_coverage__relcastclass_ldloc__relcastclass_ldloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_relcastclass_ldloc\\_relcastclass_ldloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
