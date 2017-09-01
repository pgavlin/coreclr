using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldftn_ldftn_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldftn_ldftn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldftn\\ldftn.cmd");
        }
    }
}
