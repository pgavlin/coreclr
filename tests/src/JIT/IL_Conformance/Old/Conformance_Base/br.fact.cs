using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_br_br_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_br_br_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\br\\br.cmd");
        }
    }
}
