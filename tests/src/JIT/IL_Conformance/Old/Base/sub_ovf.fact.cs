using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_sub_ovf_sub_ovf_
    {
        [Fact]
        public void _Old_Base_sub_ovf_sub_ovf_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\sub_ovf\\sub_ovf.cmd");
        }
    }
}
