using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldnull_i_ldnull_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldnull_i_ldnull_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldnull_i\\ldnull_i.cmd");
        }
    }
}
