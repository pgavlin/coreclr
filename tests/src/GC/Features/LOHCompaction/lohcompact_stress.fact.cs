using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _LOHCompaction_lohcompact_stress_lohcompact_stress_
    {
        [OuterLoop]
        [Fact]
        public void _LOHCompaction_lohcompact_stress_lohcompact_stress_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\LOHCompaction\\lohcompact_stress\\lohcompact_stress.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
