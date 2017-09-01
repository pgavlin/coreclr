using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _AssertionPropagation_CopyProp_CopyProp_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_CopyProp_CopyProp_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\CopyProp\\CopyProp.cmd");
        }
    }
}
