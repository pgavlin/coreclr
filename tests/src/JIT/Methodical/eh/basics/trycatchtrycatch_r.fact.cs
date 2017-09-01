using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_trycatchtrycatch_r_trycatchtrycatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trycatchtrycatch_r_trycatchtrycatch_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trycatchtrycatch_r\\trycatchtrycatch_r.cmd");
        }
    }
}
