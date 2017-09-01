using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_ldloca_s_i8_ldloca_s_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloca_s_i8_ldloca_s_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloca_s_i8\\ldloca_s_i8.cmd");
        }
    }
}
