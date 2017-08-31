using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _SustainedLowLatency_sustainedlowlatency_race_sustainedlowlatency_race_
    {
        [OuterLoop]
        [Fact]
        public void _SustainedLowLatency_sustainedlowlatency_race_sustainedlowlatency_race_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\SustainedLowLatency\\sustainedlowlatency_race\\sustainedlowlatency_race.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
