using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _GCBench_gcbench_gcbench_
    {
        [Fact]
        public void _GCBench_gcbench_gcbench_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\GCBench\\gcbench\\gcbench.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
