using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_brfalse_s_brfalse_s_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_brfalse_s_brfalse_s_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\brfalse_s\\brfalse_s.cmd");
        }
    }
}
