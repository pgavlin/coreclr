using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_brfalse_brfalse_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_brfalse_brfalse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\brfalse\\brfalse.cmd");
        }
    }
}
