using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_add_I4_add_I4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_add_I4_add_I4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\add_I4\\add_I4.cmd");
        }
    }
}
