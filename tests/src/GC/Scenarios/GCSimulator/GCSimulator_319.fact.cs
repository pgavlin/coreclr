using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _GCSimulator_GCSimulator_319_GCSimulator_319_
    {
        [OuterLoop]
        [Fact]
        public void _GCSimulator_GCSimulator_319_GCSimulator_319_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\GCSimulator\\GCSimulator_319\\GCSimulator_319.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
