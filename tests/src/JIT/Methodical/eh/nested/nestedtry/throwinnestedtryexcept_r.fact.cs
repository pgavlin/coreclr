using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_nestedtry_throwinnestedtryexcept_r_throwinnestedtryexcept_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_nestedtry_throwinnestedtryexcept_r_throwinnestedtryexcept_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\throwinnestedtryexcept_r\\throwinnestedtryexcept_r.cmd");
        }
    }
}
