using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_stind_i2_stind_i2_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_stind_i2_stind_i2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\stind_i2\\stind_i2.cmd");
        }
    }
}
