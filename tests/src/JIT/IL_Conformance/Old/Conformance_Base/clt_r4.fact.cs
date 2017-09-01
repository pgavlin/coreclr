using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_clt_r4_clt_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_clt_r4_clt_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\clt_r4\\clt_r4.cmd");
        }
    }
}
