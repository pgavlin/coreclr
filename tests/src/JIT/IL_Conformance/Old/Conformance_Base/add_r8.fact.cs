using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_add_r8_add_r8_
    {
        [Fact]
        public void _Old_Conformance_Base_add_r8_add_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\add_r8\\add_r8.cmd");
        }
    }
}
