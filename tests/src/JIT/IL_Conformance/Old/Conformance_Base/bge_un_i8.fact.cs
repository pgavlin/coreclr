using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bge_un_i8_bge_un_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bge_un_i8_bge_un_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bge_un_i8\\bge_un_i8.cmd");
        }
    }
}
