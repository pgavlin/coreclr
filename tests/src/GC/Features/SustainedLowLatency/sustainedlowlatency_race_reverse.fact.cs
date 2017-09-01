using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _SustainedLowLatency_sustainedlowlatency_race_reverse_sustainedlowlatency_race_reverse_
    {
        [OuterLoop]
        [Fact]
        public void _SustainedLowLatency_sustainedlowlatency_race_reverse_sustainedlowlatency_race_reverse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\SustainedLowLatency\\sustainedlowlatency_race_reverse\\sustainedlowlatency_race_reverse.cmd");
        }
    }
}
