using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_blt_blt_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_blt_blt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\blt\\blt.cmd");
        }
    }
}
