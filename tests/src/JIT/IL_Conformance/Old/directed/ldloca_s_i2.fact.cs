using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_ldloca_s_i2_ldloca_s_i2_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloca_s_i2_ldloca_s_i2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloca_s_i2\\ldloca_s_i2.cmd");
        }
    }
}
