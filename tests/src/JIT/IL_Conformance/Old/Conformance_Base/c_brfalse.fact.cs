using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_c_brfalse_c_brfalse_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_c_brfalse_c_brfalse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\c_brfalse\\c_brfalse.cmd");
        }
    }
}
