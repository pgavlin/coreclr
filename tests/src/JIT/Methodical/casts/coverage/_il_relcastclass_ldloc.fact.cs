using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_relcastclass_ldloc__il_relcastclass_ldloc_
    {
        [Fact]
        public void _casts_coverage__il_relcastclass_ldloc__il_relcastclass_ldloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_relcastclass_ldloc\\_il_relcastclass_ldloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
