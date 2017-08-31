using CoreclrTestLib;
using Xunit;

namespace performance_linkbench
{
    class _linkbench_LinkBench_
    {
        [Fact]
        public void _linkbench_LinkBench_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("performance\\linkbench\\linkbench\\LinkBench.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
