using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_bge_s_bge_s_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_bge_s_bge_s_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\bge_s\\bge_s.cmd");
        }
    }
}
