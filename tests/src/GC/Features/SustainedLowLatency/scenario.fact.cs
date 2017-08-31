using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _SustainedLowLatency_scenario_scenario_
    {
        [ActiveIssue("3392")]
        [OuterLoop]
        [Fact]
        public void _SustainedLowLatency_scenario_scenario_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\SustainedLowLatency\\scenario\\scenario.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
