using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_clt_clt_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_clt_clt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\clt\\clt.cmd");
        }
    }
}
