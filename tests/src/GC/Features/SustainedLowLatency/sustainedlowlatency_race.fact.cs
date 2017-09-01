using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _SustainedLowLatency_sustainedlowlatency_race_sustainedlowlatency_race_
    {
        [OuterLoop]
        [Fact]
        public void _SustainedLowLatency_sustainedlowlatency_race_sustainedlowlatency_race_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\SustainedLowLatency\\sustainedlowlatency_race\\sustainedlowlatency_race.cmd");
        }
    }
}
