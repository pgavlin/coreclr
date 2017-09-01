using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _LOHCompaction_lohcompact_stress_lohcompact_stress_
    {
        [OuterLoop]
        [Fact]
        public void _LOHCompaction_lohcompact_stress_lohcompact_stress_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\LOHCompaction\\lohcompact_stress\\lohcompact_stress.cmd");
        }
    }
}
