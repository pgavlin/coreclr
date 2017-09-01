using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ldind_stind_ldind_stind_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldind_stind_ldind_stind_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldind_stind\\ldind_stind.cmd");
        }
    }
}
