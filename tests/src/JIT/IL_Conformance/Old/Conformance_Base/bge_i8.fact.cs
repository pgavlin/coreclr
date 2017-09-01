using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bge_i8_bge_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bge_i8_bge_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bge_i8\\bge_i8.cmd");
        }
    }
}
