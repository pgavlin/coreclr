using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_coverage_expl_obj_1_r_expl_obj_1_r_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _explicit_coverage_expl_obj_1_r_expl_obj_1_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\coverage\\expl_obj_1_r\\expl_obj_1_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
