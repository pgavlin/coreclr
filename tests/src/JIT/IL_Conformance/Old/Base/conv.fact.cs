using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_conv_conv_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_conv_conv_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\conv\\conv.cmd");
        }
    }
}
