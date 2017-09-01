using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_trythrowcatch_ro_trythrowcatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trythrowcatch_ro_trythrowcatch_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trythrowcatch_ro\\trythrowcatch_ro.cmd");
        }
    }
}
