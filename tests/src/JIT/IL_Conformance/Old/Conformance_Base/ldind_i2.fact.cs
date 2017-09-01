using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldind_i2_ldind_i2_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldind_i2_ldind_i2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldind_i2\\ldind_i2.cmd");
        }
    }
}
