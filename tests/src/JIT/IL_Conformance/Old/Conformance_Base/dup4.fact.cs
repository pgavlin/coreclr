using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_dup4_dup4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_dup4_dup4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\dup4\\dup4.cmd");
        }
    }
}
