using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_nestedtry_nestedtryexcept_r_nestedtryexcept_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_nestedtry_nestedtryexcept_r_nestedtryexcept_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\nestedtryexcept_r\\nestedtryexcept_r.cmd");
        }
    }
}
