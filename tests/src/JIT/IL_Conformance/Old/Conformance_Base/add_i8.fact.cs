using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_add_i8_add_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_add_i8_add_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\add_i8\\add_i8.cmd");
        }
    }
}
