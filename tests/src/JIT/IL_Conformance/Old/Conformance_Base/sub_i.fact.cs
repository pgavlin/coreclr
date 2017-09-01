using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_sub_i_sub_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_sub_i_sub_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\sub_i\\sub_i.cmd");
        }
    }
}
