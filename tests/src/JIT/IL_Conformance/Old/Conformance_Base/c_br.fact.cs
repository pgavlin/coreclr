using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_c_br_c_br_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_c_br_c_br_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\c_br\\c_br.cmd");
        }
    }
}
