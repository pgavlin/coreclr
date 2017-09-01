using CoreclrTestLib;
using Xunit;

namespace performance_linkbench
{
    public class _linkbench_LinkBench_
    {
        [Fact]
        public void _linkbench_LinkBench_cmd()
        {
            CoreclrTestWrapperLib.RunTest("performance\\linkbench\\linkbench\\LinkBench.cmd");
        }
    }
}
