using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_clt_u4_clt_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_clt_u4_clt_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\clt_u4\\clt_u4.cmd");
        }
    }
}
