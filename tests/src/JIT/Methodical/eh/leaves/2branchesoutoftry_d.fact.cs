using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_2branchesoutoftry_d_2branchesoutoftry_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_2branchesoutoftry_d_2branchesoutoftry_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\2branchesoutoftry_d\\2branchesoutoftry_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
