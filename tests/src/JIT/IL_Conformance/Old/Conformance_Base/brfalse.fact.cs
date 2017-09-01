using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_brfalse_brfalse_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_brfalse_brfalse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\brfalse\\brfalse.cmd");
        }
    }
}
