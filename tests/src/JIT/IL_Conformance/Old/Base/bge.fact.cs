using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_bge_bge_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_bge_bge_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\bge\\bge.cmd");
        }
    }
}
