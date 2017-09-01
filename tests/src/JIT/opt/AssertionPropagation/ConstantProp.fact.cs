using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _AssertionPropagation_ConstantProp_ConstantProp_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_ConstantProp_ConstantProp_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\ConstantProp\\ConstantProp.cmd");
        }
    }
}
