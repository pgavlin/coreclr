using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _GCSimulator_GCSimulator_258_GCSimulator_258_
    {
        [OuterLoop]
        [Fact]
        public void _GCSimulator_GCSimulator_258_GCSimulator_258_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\GCSimulator\\GCSimulator_258\\GCSimulator_258.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
