using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _GCSimulator_GCSimulator_287_GCSimulator_287_
    {
        [OuterLoop]
        [Fact]
        public void _GCSimulator_GCSimulator_287_GCSimulator_287_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\GCSimulator\\GCSimulator_287\\GCSimulator_287.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
