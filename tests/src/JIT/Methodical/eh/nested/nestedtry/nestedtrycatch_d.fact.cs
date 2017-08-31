using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nestedtry_nestedtrycatch_d_nestedtrycatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_nestedtry_nestedtrycatch_d_nestedtrycatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\nestedtrycatch_d\\nestedtrycatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
