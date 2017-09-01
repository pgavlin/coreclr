using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_trythrowcatchfinally_do_trythrowcatchfinally_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trythrowcatchfinally_do_trythrowcatchfinally_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trythrowcatchfinally_do\\trythrowcatchfinally_do.cmd");
        }
    }
}
