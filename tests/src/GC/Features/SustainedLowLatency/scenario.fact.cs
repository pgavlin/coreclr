using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _SustainedLowLatency_scenario_scenario_
    {
        [ActiveIssue("3392")]
        [OuterLoop]
        [Fact]
        public void _SustainedLowLatency_scenario_scenario_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\SustainedLowLatency\\scenario\\scenario.cmd");
        }
    }
}
