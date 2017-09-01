using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_pop8_pop8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_pop8_pop8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\pop8\\pop8.cmd");
        }
    }
}
