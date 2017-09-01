using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_clt_i4_clt_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_clt_i4_clt_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\clt_i4\\clt_i4.cmd");
        }
    }
}
