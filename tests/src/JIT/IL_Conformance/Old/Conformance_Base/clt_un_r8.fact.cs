using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_clt_un_r8_clt_un_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_clt_un_r8_clt_un_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\clt_un_r8\\clt_un_r8.cmd");
        }
    }
}
