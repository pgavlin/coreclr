using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _GCSimulator_GCSimulator_36_GCSimulator_36_
    {
        [OuterLoop]
        [Fact]
        public void _GCSimulator_GCSimulator_36_GCSimulator_36_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\GCSimulator\\GCSimulator_36\\GCSimulator_36.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
