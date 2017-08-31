using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nestedtry_nestedtryfault_r_nestedtryfault_r_
    {
        [Fact]
        public void _eh_nested_nestedtry_nestedtryfault_r_nestedtryfault_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\nestedtryfault_r\\nestedtryfault_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
