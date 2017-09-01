using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_rem_i8_rem_i8_
    {
        [Fact]
        public void _Old_Conformance_Base_rem_i8_rem_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\rem_i8\\rem_i8.cmd");
        }
    }
}
