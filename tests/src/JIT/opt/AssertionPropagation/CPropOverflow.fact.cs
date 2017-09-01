using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _AssertionPropagation_CPropOverflow_CPropOverflow_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_CPropOverflow_CPropOverflow_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\CPropOverflow\\CPropOverflow.cmd");
        }
    }
}
