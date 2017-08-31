using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nestedtry_nestedtrycatch_r_nestedtrycatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_nestedtry_nestedtrycatch_r_nestedtrycatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\nestedtrycatch_r\\nestedtrycatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
