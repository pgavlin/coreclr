using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _GCSimulator_GCSimulator_102_GCSimulator_102_
    {
        [OuterLoop]
        [Fact]
        public void _GCSimulator_GCSimulator_102_GCSimulator_102_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\GCSimulator\\GCSimulator_102\\GCSimulator_102.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
