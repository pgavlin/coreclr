using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_trythrowcatch_do_trythrowcatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trythrowcatch_do_trythrowcatch_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trythrowcatch_do\\trythrowcatch_do.cmd");
        }
    }
}
