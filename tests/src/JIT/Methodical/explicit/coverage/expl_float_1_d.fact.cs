using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_coverage_expl_float_1_d_expl_float_1_d_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _explicit_coverage_expl_float_1_d_expl_float_1_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\coverage\\expl_float_1_d\\expl_float_1_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
