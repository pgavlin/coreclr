using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_ldloc_s_i2_ldloc_s_i2_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloc_s_i2_ldloc_s_i2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloc_s_i2\\ldloc_s_i2.cmd");
        }
    }
}
