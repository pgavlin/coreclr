using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _SustainedLowLatency_sustainedlowlatency_race_reverse_sustainedlowlatency_race_reverse_
    {
        [OuterLoop]
        [Fact]
        public void _SustainedLowLatency_sustainedlowlatency_race_reverse_sustainedlowlatency_race_reverse_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\SustainedLowLatency\\sustainedlowlatency_race_reverse\\sustainedlowlatency_race_reverse.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
