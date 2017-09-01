using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_div_div_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_div_div_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\div\\div.cmd");
        }
    }
}
