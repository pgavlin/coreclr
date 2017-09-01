using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_clt_u8_clt_u8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_clt_u8_clt_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\clt_u8\\clt_u8.cmd");
        }
    }
}
