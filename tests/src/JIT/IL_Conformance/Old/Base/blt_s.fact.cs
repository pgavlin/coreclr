using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_blt_s_blt_s_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_blt_s_blt_s_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\blt_s\\blt_s.cmd");
        }
    }
}
