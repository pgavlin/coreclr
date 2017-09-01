using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_add_ovf_add_ovf_
    {
        [Fact]
        public void _Old_Base_add_ovf_add_ovf_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\add_ovf\\add_ovf.cmd");
        }
    }
}
