using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_2branchesoutoftry_r_2branchesoutoftry_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_2branchesoutoftry_r_2branchesoutoftry_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\2branchesoutoftry_r\\2branchesoutoftry_r.cmd");
        }
    }
}
