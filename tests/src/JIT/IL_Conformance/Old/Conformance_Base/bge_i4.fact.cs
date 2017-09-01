using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bge_i4_bge_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bge_i4_bge_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bge_i4\\bge_i4.cmd");
        }
    }
}
