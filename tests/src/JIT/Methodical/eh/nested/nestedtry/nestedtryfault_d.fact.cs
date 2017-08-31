using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nestedtry_nestedtryfault_d_nestedtryfault_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_nestedtry_nestedtryfault_d_nestedtryfault_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\nestedtryfault_d\\nestedtryfault_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
