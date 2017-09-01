using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_nestedtry_throwinnestedtryexcept_d_throwinnestedtryexcept_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_nestedtry_throwinnestedtryexcept_d_throwinnestedtryexcept_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\throwinnestedtryexcept_d\\throwinnestedtryexcept_d.cmd");
        }
    }
}
