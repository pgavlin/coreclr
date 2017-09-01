using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _GCSimulator_GCSimulator_64_GCSimulator_64_
    {
        [OuterLoop]
        [Fact]
        public void _GCSimulator_GCSimulator_64_GCSimulator_64_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\GCSimulator\\GCSimulator_64\\GCSimulator_64.cmd");
        }
    }
}
