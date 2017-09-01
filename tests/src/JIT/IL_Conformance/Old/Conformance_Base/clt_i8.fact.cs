using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_clt_i8_clt_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_clt_i8_clt_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\clt_i8\\clt_i8.cmd");
        }
    }
}
