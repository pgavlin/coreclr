using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_coverage_seq_obj_1_r_seq_obj_1_r_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _explicit_coverage_seq_obj_1_r_seq_obj_1_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\coverage\\seq_obj_1_r\\seq_obj_1_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
